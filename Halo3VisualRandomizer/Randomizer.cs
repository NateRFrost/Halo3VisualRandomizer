using System;
using System.Diagnostics;
using static Halo3VisualRandomizer.RandomizedItems.RandomizedItems;
using Bungie;
using Bungie.Tags;
using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Halo3VisualRandomizer
{ 
	public partial class Randomizer
	{
        public int Seed = 0;
        public string ek_path = "";
		public Randomizer(string ek_path = @"C:\Program Files (x86)\Steam\steamapps\common\H3EK")
		{
			Random rand = new Random(Seed);
            this.ek_path = ek_path;

        }

		public void Randomize(RandomizerSettings settings, IProgress<int> progress, IProgress<string> text_progress)
		{
			Debug.WriteLine("Beginning randomization");
            progress.Report(3);
            text_progress.Report("Unzipping game data. This can take 5+ minutes");
            UnzipTags(settings);
            progress.Report(10);
            var param = new ManagedBlamStartupParameters();
            ManagedBlamCrashCallback del = info => { };
            if (!ManagedBlamSystem.IsInitialized)
            {
                //ManagedBlamSystem.Start(settings.EkPath, del, param);
                ManagedBlamSystem.InitializeProject(InitializationType.TagsOnly, settings.EkPath);

            }

            text_progress.Report("Giving vehicle and weapon animations for characters");
            progress.Report(14);
            FixAnimationGraphs();
            //text_progress.Report("Fixing jetpack enemies");
            progress.Report(17);
            FixCharacterProperties();
            if (settings.RandomizeCutscenes)
            {
                text_progress.Report("Randomizing cutscenes");
                RandomizeCutscenes(settings);
            }
            int level_no = 0;
            foreach (Level level in Levels)
			{
                level_no++;
                if (level.Randomize)
                {
                    Debug.WriteLine("Beginning randomization for " + level.FancyName);
                    LevelRandomizer level_randomizer = new LevelRandomizer(level, settings);
                    level_randomizer.Randomize();
                    text_progress.Report("Building " + level.FancyName + ". This can take 5+ minutes");
                    System.Threading.Thread.Sleep(500);
                    level_randomizer.BuildCacheFile();
                    System.Threading.Thread.Sleep(500);
                    level_randomizer.CopyFileToMCC();
                    level_randomizer.DeleteFromEk();
                    Debug.WriteLine("Finished randomization for " + level.FancyName);
                    text_progress.Report("The level " + level.FancyName + " is ready to play (recommended to wait until the next mission is done before playing)");
                }
                progress.Report(20 + ((80 / Levels.Count) * level_no));
            }
            //ManagedBlamSystem.Stop();
            progress.Report(100);
            text_progress.Report("Finished randomizing all levels");
            Debug.WriteLine("Finished randomization");
        }

        public void UnzipTags(RandomizerSettings settings)
        {
            Debug.WriteLine("Unzipping tags");
            string seven_z_path = "7za.exe";
            try
            {
                ProcessStartInfo process = new ProcessStartInfo();
                process.WindowStyle = ProcessWindowStyle.Hidden;
                process.FileName = seven_z_path;
                process.Arguments = string.Format("x \"{0}\" -o\"{1}\" -y", settings.EkPath + @"\H3EK.7z", settings.EkPath);
                Process x = Process.Start(process);
                x?.WaitForExit();
            }
            catch (System.Exception e)
            {
                throw new Exception("7za.exe failed\n" + e);
            }
        }

        public void FixAnimationGraphs()
        {
            foreach (var animation_graph in animation_graphs)
            {
                Debug.WriteLine("Fixing animation graph: " + animation_graph.Path);
                var tag_path = TagPath.FromPathAndExtension(animation_graph.Path, "model_animation_graph");
                using (TagFile tag_file = new TagFile(tag_path))
                {
                    var content = GetField(tag_file, "content");
                    var modes = ((TagFieldStruct)content).Elements[0].Fields.Where(x => x.DisplayName == "modes").FirstOrDefault();
                    if (modes != null)
                    {
                        //Create missing animation modes from analagous animation modes (ie warthog passenger animation is copied from revenant passenger animation)
                        foreach (List<string> animation_mode_group in animation_mode_groups)
                        {
                            int index = -1;
                            foreach (TagFieldBlockElement mode in ((TagFieldBlock)modes).Elements)
                            {
                                var label = mode.Fields.Where(x => x.DisplayName == "label").FirstOrDefault();
                                if (label != null)
                                {
                                    if (animation_mode_group.Contains(((TagFieldElementStringID)label).Data))
                                    {
                                        index = mode.ElementIndex;
                                        break;
                                    }
                                }
                            }
                            if (index != -1)
                            {
                                foreach (string animation_mode in animation_mode_group)
                                {
                                    bool found = false;
                                    foreach (TagFieldBlockElement mode in ((TagFieldBlock)modes).Elements)
                                    {
                                        var label = mode.Fields.Where(x => x.DisplayName == "label").FirstOrDefault();
                                        if (label != null)
                                        {
                                            if (((TagFieldElementStringID)label).Data == animation_mode)
                                            {
                                                found = true;
                                                break;
                                            }
                                        }
                                    }
                                    if (!found)
                                    {
                                        TagFieldBlock modes_block = (TagFieldBlock)modes;
                                        modes_block.DuplicateElement(index);
                                        System.Threading.Thread.Sleep(100);

                                        var new_mode = modes_block.Elements[modes_block.Elements.Count - 1];
                                        var label = new_mode.Fields.Where(x => x.DisplayName == "label").FirstOrDefault();
                                        if (label != null)
                                        {
                                            ((TagFieldElementStringID)label).Data = animation_mode;
                                        }
                                        else
                                        {
                                            Debug.WriteLine("failed to copy mode element");
                                        }
                                    }
                                }
                            }
                        }

                        //Add missing weapon classes for each animation mode
                        /*
                        List<string> weapon_classes_found = new List<string>();
                        foreach (TagFieldBlockElement mode in ((TagFieldBlock)modes).Elements)
                        {
                            var weapon_class_block = mode.Fields.Where(x => x.DisplayName == "weapon class").FirstOrDefault();
                            if (weapon_class_block != null)
                            {
                                
                                foreach (var weapon_class_element in ((TagFieldBlock)weapon_class_block).Elements)
                                {
                                    var label = weapon_class_element.Fields.Where(x => x.DisplayName == "label").FirstOrDefault();
                                    if (label != null)
                                    {
                                        string weapon_class_string = ((TagFieldElementStringID)label).Data;
                                        if (weapon_classes.Contains(weapon_class_string))
                                        {
                                            weapon_classes_found.Add(weapon_class_string);
                                        }
                                    }
                                }

                            }
                        }
                        */
                        foreach (TagFieldBlockElement mode in ((TagFieldBlock)modes).Elements)
                        {
                            
                            var weapon_class_block = mode.Fields.Where(x => x.DisplayName == "weapon class").FirstOrDefault();
                            if (weapon_class_block != null)
                            {
                                /*
                                List<string> mode_weapon_classes_found = new List<string>();
                                foreach (var weapon_class_element in ((TagFieldBlock)weapon_class_block).Elements)
                                {
                                    var label = weapon_class_element.Fields.Where(x => x.DisplayName == "label").FirstOrDefault();
                                    if (label != null)
                                    {
                                        string weapon_class_string = ((TagFieldElementStringID)label).Data;
                                        if (weapon_classes.Contains(weapon_class_string))
                                        {
                                            mode_weapon_classes_found.Add(weapon_class_string);
                                        }
                                    }
                                }
                                */
                                foreach (var weapon_class_copy_group in animation_graph.weapon_class_copy_groups)
                                {
                                    foreach (var weapon_class in weapon_class_copy_group.WeaponClassesCopyTo)
                                    {
                                        //if (!mode_weapon_classes_found.Contains(weapon_class))
                                        int copy_weapon_class_index = -1;
                                        foreach (var copy_weapon_class in weapon_class_copy_group.WeaponClassesCopyFrom)
                                        {
                                            foreach (var weapon_class_element in (TagFieldBlock)weapon_class_block)
                                            {
                                                var label = weapon_class_element.Fields.Where(x => x.DisplayName == "label").FirstOrDefault();
                                                if (label != null)
                                                {
                                                    string weapon_class_string = ((TagFieldElementStringID)label).Data;
                                                    if (copy_weapon_class_index == -1 && copy_weapon_class.Contains(weapon_class_string))
                                                    {
                                                        //Debug.WriteLine("copying " + copy_weapon_class + " to " + weapon_class);
                                                        copy_weapon_class_index = weapon_class_element.ElementIndex;
                                                        break;
                                                    }
                                                }
                                            }
                                            if (copy_weapon_class_index != -1)
                                            {
                                                ((TagFieldBlock)weapon_class_block).DuplicateElement(copy_weapon_class_index);
                                                System.Threading.Thread.Sleep(100);
                                                var new_weapon_class = ((TagFieldBlock)weapon_class_block).Elements[((TagFieldBlock)weapon_class_block).Elements.Count - 1];
                                                var label = new_weapon_class.Fields.Where(x => x.DisplayName == "label").FirstOrDefault();
                                                if (label != null)
                                                {
                                                    ((TagFieldElementStringID)label).Data = weapon_class;
                                                }
  
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        throw new Exception("modes not found for " + animation_graph);
                    }
                    tag_file.Save();

                }
            }
        }

        public void FixCharacterProperties()
        {
            Debug.WriteLine("Fixing character properties");
            var tag_path = TagPath.FromPathAndType(@"ai\generic", "char");
            using (TagFile tag_file = new TagFile(tag_path))
            {
                foreach (var weapon in weapons.List)
                {
                    var weapons_properties_block = GetField(tag_file, "weapons properties");
                    foreach (TagElement weapon_property in ((TagFieldBlock)weapons_properties_block).Elements)
                    {
                        var weapon_field = GetField(weapon_property, "weapon");
                        
                        if (((TagFieldReference)weapon_field).Path.RelativePath == weapon.CopyPropertiesFrom)
                        {
                            Debug.WriteLine("duplicating weapon property for " + weapon.Name );
                            var copy_index = ((TagElement)weapon_property).ElementIndex;
                            ((TagFieldBlock)weapons_properties_block).DuplicateElement(copy_index);
                            System.Threading.Thread.Sleep(200);
                            break;
                        }
                    }
                    foreach (TagElement weapon_property in ((TagFieldBlock)weapons_properties_block).Elements)
                    {
                        var weapon_field = GetField(weapon_property, "weapon");
                        if (((TagFieldReference)weapon_field).Path.RelativePath == weapon.CopyPropertiesFrom)
                        {
                            Debug.WriteLine("setting weapon property for " + weapon.Name + " over " + ((TagFieldReference)weapon_field).Path.RelativePath);
                            ((TagFieldReference)weapon_field).Path = TagPath.FromPathAndType(weapon.Path, weapons.Type);
                            break;
                        }

                    }
                    var firing_pattern_block = GetField(tag_file, "firing pattern properties");
                    foreach (TagElement firing_pattern in ((TagFieldBlock)firing_pattern_block).Elements)
                    {
                        var weapon_field = GetField(firing_pattern, "weapon");
                        if (((TagFieldReference)weapon_field).Path.RelativePath == weapon.CopyPropertiesFrom)
                        {
                            Debug.WriteLine("duplicating firing pattern properties for " + weapon.Name);
                            var copy_index = ((TagElement)firing_pattern).ElementIndex;
                            ((TagFieldBlock)firing_pattern_block).DuplicateElement(copy_index);
                            System.Threading.Thread.Sleep(200);
                            break;
                        }
                    }
                    foreach (TagElement firing_pattern in ((TagFieldBlock)firing_pattern_block).Elements)
                    {
                        var weapon_field = GetField(firing_pattern, "weapon");
                        if (((TagFieldReference)weapon_field).Path.RelativePath == weapon.CopyPropertiesFrom)
                        {
                            Debug.WriteLine("setting firing pattern properties for " + weapon.Name + " over " + ((TagFieldReference)weapon_field).Path.RelativePath);
                            ((TagFieldReference)weapon_field).Path = TagPath.FromPathAndType(weapon.Path, weapons.Type);
                            break;
                        }
                    }
                }
                foreach (var vehicle in vehicles.List)
                {
                    var vehicle_properties_block = GetField(tag_file, "vehicle properties");
                    foreach (TagElement vehicle_property in ((TagFieldBlock)vehicle_properties_block).Elements)
                    {
                        var unit_field = GetField(vehicle_property, "unit");
                        if (((TagFieldReference)unit_field).Path.RelativePath == vehicle.CopyPropertiesFrom)
                        {
                            Debug.WriteLine("duplicating vehicle property for " + vehicle.Name);
                            var copy_index = ((TagElement)vehicle_property).ElementIndex;
                            ((TagFieldBlock)vehicle_properties_block).DuplicateElement(copy_index);
                            System.Threading.Thread.Sleep(200);
                            break;
                        }
                    }
                    foreach (TagElement vehicle_property in ((TagFieldBlock)vehicle_properties_block).Elements)
                    {
                        var unit_field = GetField(vehicle_property, "unit");
                        if (((TagFieldReference)unit_field).Path.RelativePath == vehicle.CopyPropertiesFrom)
                        {
                            Debug.WriteLine("setting vehicle property for " + vehicle.Name + " over " + ((TagFieldReference)unit_field).Path.RelativePath);
                            ((TagFieldReference)unit_field).Path = TagPath.FromPathAndType(vehicle.Path, vehicles.Type);
                            break;
                        }

                    }
                }

                    tag_file.Save();
            }    
            
        }

        public void RandomizeCutscenes(RandomizerSettings settings)
        {
            Random rand = new Random(settings.Seed);
            foreach (var cutscene in cutscenes)
            {
                Debug.WriteLine("Randomizing cutscene: " + cutscene);
                var tag_path = TagPath.FromPathAndType(cutscene, "cisc*");
                //Debug.WriteLine("Got tag Path");
                using (TagFile tag_file = new TagFile(tag_path))
                {
                    //Debug.WriteLine("using tag file");
                    var shots_field = GetField(tag_file, "shots");
                    foreach (var shot_element in ((TagFieldBlock)shots_field).Elements)
                    {
                        //Debug.WriteLine("shot element");
                        var dialogue_field = GetField(shot_element, "dialogue");
                        foreach (var dialogue_element in ((TagFieldBlock)dialogue_field).Elements)
                        {
                            RandomizedObjectDetails random_dialogue = dialogue.GetRandomObjectWeighted(rand);
                            if (random_dialogue != null)
                            {
                                foreach (var field in dialogue_element.Fields)
                                {
                                    if (field.DisplayName == "dialogue" || field.DisplayName == "female dialogue")
                                    {
                                        TagPath random_dialgoue_path = TagPath.FromPathAndType(random_dialogue.Path, "snd!");
                                        ((TagFieldReference)field).Path = random_dialgoue_path;
                                    }
                                    if (field.DisplayName == "subtitle" || field.DisplayName == "female subtitle")
                                    {
                                        ((TagFieldElementStringID)field).Data = random_dialogue.Subtitle;
                                    }
                                }
                            }
                            else
                            {
                                Debug.Print("No random dialogue found");
                            }
                        
                        }
                    }
                    var scene_objects = GetField(tag_file, "objects");
                    foreach (var object_element in ((TagFieldBlock)scene_objects).Elements)
                    {
                        string object_type_path = null;
                        foreach (var field in object_element.Fields)
                        {
                            if (field.DisplayName == "object type")
                            {
                                if (((TagFieldReference)field).Path != null)
                                {
                                    object_type_path = ((TagFieldReference)field).Path.RelativePath;
                                }
                            }
                        }
                        if (object_type_path != null && bipeds.List.Any(x=> object_type_path == x.Path))
                        {
                            foreach (var field in object_element.Fields)
                            {
                                if (field.DisplayName == "variant name")
                                {
                                    var biped_type = bipeds.List.Where(List => object_type_path == List.Path).FirstOrDefault();
                                    if (biped_type != null)
                                    {
                                        var variant = biped_type.Variants.GetRandomObjectWeighted(rand);
                                        if (variant != null)
                                        {
                                            ((TagFieldElementStringID)field).Data = variant.Name;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    tag_file.Save();
                }
            }
        }



        private static TagField GetField(TagFile tag_file, string field_name)
        {
            var fields_found = new List<string>();
            foreach (var field in tag_file.Fields)
            {
                fields_found.Add(field.DisplayName);
                if (field.DisplayName == field_name)
                {
                    return field;
                }
            }
            throw new Exception("Field not found\nTag file: " + tag_file.Path  + "\nField: " + field_name + "\nvalid fields:\n" + string.Join("\n", fields_found));
        }

        private static TagField GetField(TagElement tag_element, string field_name)
        {
            foreach (var field in tag_element.Fields)
            {
                if (field.DisplayName == field_name)
                {
                    return field;
                }
            }
            throw new Exception("Field not found: " + field_name);
        }

        private static bool FieldExists(TagElement tag_element, string field_name)
        {
            foreach (var field in tag_element.Fields)
            {
                if (field.DisplayName == field_name)
                {
                    return true;
                }
            }
            return false;
        }
    }


}
