using System;
using System.Diagnostics;
using static Halo3VisualRandomizer.RandomizedItems;
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
	public class Randomizer
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

            text_progress.Report("Giving vehicle and weapon animations for enemies");
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


        private class LevelRandomizer
		{
            Level Level;
            string LevelPath;
            string LevelFolderPath;
            TagFile TagFile;
            Random Rand;

            RandomizerSettings Settings;

            public LevelRandomizer(Level level, RandomizerSettings settings)
			{
                Level = level;
                Settings = settings;
                int seed = settings.Seed;
                foreach (char c in level.Name)
                    seed += c % 500;
                Rand = new Random(seed);
                LevelPath = @"levels\solo\" + level.Name + @"\" + level.Name;
                LevelFolderPath = @"levels\solo\" + level.Name;
                var test_path = Bungie.Tags.TagPath.FromPathAndType(LevelPath, "scnr*");
                TagFile = new Bungie.Tags.TagFile(test_path);
            }

			public void Randomize()
			{
                if (!Level.CutsceneOnly)
                {
                    AddToPalettes();
                    ClearDesignerZones();
                    if (Settings.RandomizeStartingProfiles)
                    {
                        RandomizeProfiles();
                    }
                    RandomizeVariousWorldObjects();
                    if (Settings.RandomizeSquads)
                    {
                        //RemoveAiResources();
                        RandomizeSquads();
                        if (Level.HasAiResources)
                        {
                            AddToAiResourcePalettes();
                            RandomizeAiResourcesSquads();

                        }
                    }
                    
                }
                
                Debug.WriteLine("saving scenario");
                TagFile.Save();
                // bad code. ideally disposing the tag file should happen elsewhere
                TagFile.Dispose();
            }

            public void BuildCacheFile()
            {
                Debug.WriteLine("Building cache file: " + LevelPath);
                
                string tool_path = Settings.EkPath + @"\tool.exe";
                try
                {
                    ProcessStartInfo process = new ProcessStartInfo();
                    process.WindowStyle = ProcessWindowStyle.Hidden;
                    process.FileName = tool_path;
                    process.Arguments = string.Format("build-cache-file " + LevelPath);
                    process.WorkingDirectory = Settings.EkPath;
                    Process x = Process.Start(process);
                    x.WaitForExit();
                }
                catch (System.Exception e)
                {
                    throw new Exception("Building cache file failed\n" + e);
                }
            
            }

            public void CopyFileToMCC()
            {
                string fileToCopy = Settings.EkPath + @"\maps\" + Level.Name + @".map";
                string destinationDirectory = Settings.MCCPath + @"\halo3\maps\";
                var start_time = DateTime.Now;
                while (!File.Exists(fileToCopy))
                {
                    System.Threading.Thread.Sleep(1000);
                    if (DateTime.Now - start_time > TimeSpan.FromMinutes(5))
                    {
                        throw new Exception("File not found: " + fileToCopy);
                    }
                }
                File.Copy(fileToCopy, destinationDirectory + Path.GetFileName(fileToCopy), true);
            }

            public void MoveFileToMCC()
            {
                string fileToMove = Settings.EkPath + @"\maps\" + Level.Name + @".map";
                string destinationDirectory = Settings.MCCPath + @"\halo3\maps\";
                var start_time = DateTime.Now;
                while (!File.Exists(fileToMove))
                {
                    System.Threading.Thread.Sleep(1000);
                    if (DateTime.Now - start_time > TimeSpan.FromMinutes(5))
                    {
                        throw new Exception("File not found: " + fileToMove);
                    }
                }
                File.Move(fileToMove, destinationDirectory + Path.GetFileName(fileToMove));
            }

            public void DeleteFromEk()
            {
                string fileToDelete = Settings.EkPath + @"\maps\" + Level.Name + @".map";
                File.Delete(fileToDelete);
            }

            private static void AddObjectsToPalette(TagField palette, RandomizedObjectList randomized_object_list)
            {
                TagFieldBlock palette_block = (TagFieldBlock)palette;
                foreach (var object_type in randomized_object_list.List)
                {
                    if(object_type.Weight != 0)
                    {
                        bool found = false;
                        foreach (var element in palette_block.Elements)
                        {
                            if (element.ElementHeaderText.ToLower().Contains(object_type.Name.ToLower()))
                            {
                                found = true;
                                break;
                            }
                        }
                        if (!found)
                        {
                            int count = palette_block.Elements.Count;
                            palette_block.AddElement();

                            var tag = ((TagFieldBlockElement)palette_block.Elements[count]);
                            var tgb = (TagFieldReference)tag.Fields[0];

                            tgb.Path = TagPath.FromPathAndType(object_type.Path, randomized_object_list.Type);
                            //tgb.Path = TagPath.FromPathAndExtension(object_type.Path, randomized_object_list.Type);


                        }
                    }
                }
                foreach (var element in palette_block.Elements)
                {
                    foreach (var object_type in randomized_object_list.List)
                    {
                        if (element.ElementHeaderText.ToLower() == object_type.Name.ToLower())
                        {
                            object_type.PaletteIndex = element.ElementIndex;
                            //break;
                            continue;
                        }
                    }
                }
                foreach (var object_type in randomized_object_list.List)
                {
                    if (object_type.PaletteIndex == -1 && object_type.Weight != 0)
                    {
                        Debug.WriteLine(object_type.Name + " was not successfully added to the palette");
                    }
                }
            }

            private static void AddObjectsToTag(TagFile tag_file, RandomizedObjectList randomized_object_list, bool ai_resources = false)
            {
                string palette_name = randomized_object_list.PaletteName;
                if (ai_resources)
                {
                    palette_name = randomized_object_list.PaletteNameAiResources;
                }
                var new_palette = tag_file.Fields.Where(x => x.DisplayName.Contains(palette_name)).FirstOrDefault();
                if (new_palette != null)
                {
                    {
                        AddObjectsToPalette(new_palette, randomized_object_list);
                    }
                }
            }

            private void AddToResourcePalette(RandomizedObjectList randomized_object_list)
            {
                Debug.WriteLine("adding to resource palette: " + randomized_object_list.Name);
                //TagPath tag_path = TagPath.FromPathAndType(LevelResourcesPath, randomized_object_list.ResourceFileType);
                var resources_path = LevelFolderPath + @"\resources\" + Level.Name;
                TagPath tag_path = TagPath.FromPathAndExtension(resources_path, randomized_object_list.ResourceFileExtension);
                //Debug.WriteLine(tag_path.Type);
                using (TagFile resource_file = new TagFile(tag_path))
                {
                    //Debug.WriteLine(resource_file.Path);
                    AddObjectsToTag(resource_file, randomized_object_list);
                    resource_file.Save();
                }
            }

            private void AddToAiResourcePalette(RandomizedObjectList randomized_object_list)
            {
                Debug.WriteLine("adding to ai resource palette: " + randomized_object_list.Name);
                var resources_path = LevelFolderPath + @"\ai_resources\" + Level.Name + @"_master";
                TagPath tag_path = TagPath.FromPathAndExtension(resources_path, "scenario_ai_resource");
                using (TagFile resource_file = new TagFile(tag_path))
                {
                    AddObjectsToTag(resource_file, randomized_object_list, true);
                    resource_file.Save();
                }
            }

            private void AddToScenarioPalette(RandomizedObjectList randomized_object_list)
            {
                Debug.WriteLine("adding to scenario palette: " + randomized_object_list.Name);
                AddObjectsToTag(TagFile, randomized_object_list);
            }

            private void AddToPalettes()
            {
                Debug.WriteLine("Adding to Palettes");
                vehicles.ResetIndexes();
                weapons.ResetIndexes();
                equipments.ResetIndexes();
                scenerys.ResetIndexes();
                crates.ResetIndexes();
                //machines.ResetIndexes();
                characters.ResetIndexes();
                AddToResourcePalette(vehicles);
                AddToResourcePalette(weapons);
                AddToResourcePalette(equipments);
                AddToResourcePalette(scenerys);
                AddToResourcePalette(crates);
                AddToScenarioPalette(characters);
                //AddToResourcePalette(machines);
                AddToScenarioPalette(vehicles);
                AddToScenarioPalette(characters);
                AddToScenarioPalette(weapons);
                //AddToScenarioPalette(equipments);
            }

            private void AddToAiResourcePalettes()
            {
                Debug.WriteLine("Adding to ai resource palette");
                vehicles.ResetIndexes();
                weapons.ResetIndexes();
                //equipments.ResetIndexes();
                characters.ResetIndexes();
                AddToAiResourcePalette(vehicles);
                AddToAiResourcePalette(weapons);
                //AddToAiResourcePalette(equipments);
                AddToAiResourcePalette(characters);
            }

            private void RandomizeWorldObjects(RandomizedObjectList randomized_object_list)
            {
                Debug.WriteLine("randomizing world objects: " + randomized_object_list.Name);
                var resources_path = LevelFolderPath + @"\" + randomized_object_list.ResourcesFolder + @"\" + Level.Name;
                var tag_path = TagPath.FromPathAndExtension(resources_path, randomized_object_list.ResourceFileExtension);
                using (var resource_file = new TagFile(tag_path))
                {
                    var tag_field_block = GetField(resource_file, randomized_object_list.Name);
                    foreach (var element in ((TagFieldBlock)tag_field_block).Elements)
                    {
                        var name_field = ((TagElement)element).Fields.Where(x => x.DisplayName == "name").FirstOrDefault();
                        if (name_field != null)
                        {
                            //TagFieldBlock names_block = ((TagFieldBlockIndex)name_field).GetReferencedBlock();
                            TagFieldBlock names_block = (TagFieldBlock)GetField(resource_file, "names");

                            var index = ((TagFieldBlockIndex)name_field).Value;
                            if (index >= 0)
                            {
                                var name_element = ((TagFieldBlock)names_block).Elements[((TagFieldBlockIndex)name_field).Value];
                                var name_string_field = name_element.Fields.Where(x => x.DisplayName == "name").FirstOrDefault();
                                if (name_string_field != null)
                                {
                                    var name = ((TagFieldElementString)name_string_field).Data;
                                    if (skipSpecialObjects.Contains(name.ToLower()))
                                    {
                                        Debug.WriteLine("Skipping randomizing object: " + name);
                                        continue;
                                    }
                                }
                            }
                            
                        }
                        var type_field = ((TagElement)element).Fields.Where(x => x.DisplayName == "type").FirstOrDefault();
                        if (type_field != null)
                        {
                            int index = ((TagFieldBlockIndex)type_field).Value;
                            var object_type = randomized_object_list.List.Where(x => x.PaletteIndex == index).FirstOrDefault();
                            //if (randomized_object_list.List.Any(x => x.PaletteIndex == index))
                            if (object_type != null && (object_type.SubCategory != SubCategory.WeaponStash || Settings.RandomizeWeaponStashTypes))
                            {
                                var randomized_object = randomized_object_list.GetRandomObjectWeighted(Rand, require_palette_index: true);
                                if (randomized_object != null && randomized_object.PaletteIndex != -1)
                                {
                                    ((TagFieldBlockIndex)type_field).Value = randomized_object.PaletteIndex;
                                    TagFieldStruct weapon_data = (TagFieldStruct)((TagElement)element).Fields.Where(x => x.DisplayName == "weapon data").FirstOrDefault();
                                    if (weapon_data != null)
                                    {
                                        var roundsLeft = ((TagElement)weapon_data.Elements.First()).Fields.Where(x => x.DisplayName == "rounds left").FirstOrDefault();
                                        if (roundsLeft != null)
                                        {
                                            ((TagFieldElementInteger)roundsLeft).Data = 0;
                                        }
                                        var roundsLoaded = ((TagElement)weapon_data.Elements.First()).Fields.Where(x => x.DisplayName == "rounds loaded").FirstOrDefault();
                                        if (roundsLoaded != null)
                                        {
                                            ((TagFieldElementInteger)roundsLoaded).Data = 0;
                                        }
                                    }
                                    TagFieldStruct object_data = (TagFieldStruct)((TagElement)element).Fields.Where(x => x.DisplayName == "object data").FirstOrDefault();
                                    if (object_data != null && randomized_object.SubCategory == SubCategory.Obstacle)
                                    {
                                        var rotation = ((TagElement)object_data.Elements.First()).Fields.Where(x => x.DisplayName == "rotation").FirstOrDefault();
                                        if (rotation != null)
                                        {
                                            float[] floatArray = { 0.0f, 0.0f, 0.0f };
                                            ((TagFieldElementArraySingle)rotation).Data = floatArray;
                                            
                                            
                                        }
                                    }
                                }
                            }
                            index = ((TagFieldBlockIndex)type_field).Value;
                            object_type = randomized_object_list.List.Where(x => x.PaletteIndex == index).FirstOrDefault();
                            if (object_type != null)
                            {
                                
                                TagFieldStruct permutationData;
                                permutationData = (TagFieldStruct)((TagElement)element).Fields.Where(x => x.DisplayName == "permutation data").FirstOrDefault();
                                if (permutationData != null)
                                {
                                    var variant_name_field = ((TagElement)permutationData.Elements.First()).Fields.Where(x => x.DisplayName == "variant name").FirstOrDefault();
                                    if (variant_name_field != null)
                                    {
                                        var variant = object_type.Variants.GetRandomObjectWeighted(Rand);
                                        if (variant != null)
                                        {
                                            ((TagFieldElementStringID)variant_name_field).Data = variant.Name;
                                        }
                                        else
                                        {
                                            ((TagFieldElementStringID)variant_name_field).Data = "";
                                        }
                                    }
                                }
                            }
                        }
                        
                    }
                    resource_file.Save();
                }
            }

            private void RandomizeVariousWorldObjects()
            {
                if (Settings.RandomizeVehicles)
                {
                    RandomizeWorldObjects(vehicles);
                }
                if (Settings.RandomizeWeapons)
                {
                    RandomizeWorldObjects(weapons);
                }
                if (Settings.RandomizeEquipments)
                {
                    RandomizeWorldObjects(equipments);
                }
                if (Settings.RandomizeEnvironmentalObjects)
                {
                    RandomizeWorldObjects(scenerys);
                    RandomizeWorldObjects(crates);
                    //RandomizeWorldObjects(machines);
                }
                
            }

            private void ClearDesignerZones()
            {
                TagField designer_zones = GetField(TagFile, "designer zones");
                if (designer_zones != null)
                {
                    foreach (TagElement designer_zone in ((TagFieldBlock)designer_zones).Elements)
                    {
                        foreach (string block_type in new List<string> { "character", "vehicle", "equipment", "weapon", "scenery", "crate" })
                        {
                            var tag_field_block = designer_zone.Fields.Where(x => x.FieldPathWithoutIndexes.Contains("Block:" + block_type)).FirstOrDefault();
                            //var tag_field_block = GetField(designer_zone, block_type);
                            if (tag_field_block != null)
                            {
                                ((TagFieldBlock)tag_field_block).RemoveAllElements();
                            }
                            else
                            {
                                throw new Exception("tag field block not found" + block_type);
                            }
                        }
                    }
                }
                else
                {
                    throw new Exception("designer zones not found");
                }
            }

            private void RandomizeProfiles()
            {
                var profiles_field = GetField(TagFile, "player starting profile");
                foreach (var profile in ((TagFieldBlock)profiles_field).Elements)
                {
                    var primary_type = weapons.GetRandomObjectWeighted(Rand, require_palette_index: true);
                    var secondary_type = weapons.GetRandomObjectWeighted(Rand, require_palette_index: true);
                    var equipment_type = equipments.GetRandomObjectWeighted(Rand, require_palette_index: true, subcategories: new List<SubCategory>{SubCategory.ArmorAbility});
                    foreach (var field in profile.Fields)
                    {
                        if (field.FieldName == "primary weapon" && primary_type != null)
                        {
                            ((TagFieldReference)field).Path = TagPath.FromPathAndType(primary_type.Path, "weap");
                        }
                        else if (field.FieldName == "secondary weapon" && secondary_type != null)
                        {
                            ((TagFieldReference)field).Path = TagPath.FromPathAndType(secondary_type.Path, "weap");
                        }
                        else if (field.FieldName == "starting equipment" && equipment_type != null)
                        {
                            ((TagFieldReference)field).Path = TagPath.FromPathAndType(equipment_type.Path, "eqip");
                        }
                        else if (field.FieldName == "primaryrounds loaded" && primary_type != null)
                        {
                            ((TagFieldElementInteger)field).Data = primary_type.AmmoMag;
                        }
                        else if (field.FieldName == "secondaryrounds loaded" && secondary_type != null)
                        {
                            ((TagFieldElementInteger)field).Data = secondary_type.AmmoMag;
                        }
                        else if (field.FieldName == "primaryrounds total" && primary_type != null)
                        {
                            ((TagFieldElementInteger)field).Data = primary_type.AmmoTotal;
                        }
                        else if (field.FieldName == "secondaryrounds total" && secondary_type != null)
                        {
                            ((TagFieldElementInteger)field).Data = secondary_type.AmmoTotal;
                        }
                        var grenadeValues = new List<string> { "starting fragmentation grenade count", "starting plasma grenade count", "starting claymore grenade count", "starting firebomb grenade count" };
                        if (grenadeValues.Contains(field.FieldName, StringComparer.OrdinalIgnoreCase))
                        {
                            ((TagFieldElementInteger)field).Data = Rand.Next(0, 3);
                        }
                    }
                }
            }

            private void RemoveAiResources()
            {
                var resources_block = GetField(TagFile, "scenario resources");
                foreach (TagElement resources in ((TagFieldBlock)resources_block).Elements)
                {
                    var ai_resources_block = GetField(resources, "ai resources");
                    ((TagFieldBlock)ai_resources_block).RemoveAllElements();
                }
            }

            private void RandomizeSquads()
            {
                TagField squads = GetField(TagFile, "squads");
                if (squads != null)
                {
                    foreach (TagElement squad in ((TagFieldBlock)squads).Elements)
                    {
                        SquadRandomizer squad_randomizer = new SquadRandomizer(squad, Rand, Settings);
                        squad_randomizer.Randomize();
                    }
                }
            }

            private void RandomizeAiResourcesSquads()
            {
                Debug.WriteLine("Randomizing Ai resource squads");
                var resources_path = LevelFolderPath + @"\ai_resources\" + Level.Name + @"_master";
                TagPath tag_path = TagPath.FromPathAndExtension(resources_path, "scenario_ai_resource");
                using (TagFile resource_file = new TagFile(tag_path))
                {
                    TagField squads = GetField(resource_file, "squads");
                    if (squads != null)
                    {
                        foreach (TagElement squad in ((TagFieldBlock)squads).Elements)
                        {
                            SquadRandomizer squad_randomizer = new SquadRandomizer(squad, Rand, Settings);
                            squad_randomizer.Randomize();
                        }
                    }

                    resource_file.Save();
                }
            }




            private class SquadRandomizer
            {
                TagElement Squad;
                Random Rand;
                RandomizerSettings Settings;

                RandomizedObjectDetails old_vehicle;
                bool SkipSpecialEnemyTypes = false;
                bool SkipCharacter = false;
                bool HasVehicle = false;
                bool MakeHunter = false;
                TagFieldEnum TeamField;

                public SquadRandomizer(TagElement squad, Random rand, RandomizerSettings settings)
                {
                    Squad = squad;
                    Rand = rand;
                    Settings = settings;
                    TeamField = (TagFieldEnum)GetField(Squad, "team");

                    if (skipSpecialEnemySquads.Any(x => Squad.ElementHeaderText.ToLower().Contains(x.ToLower())))
                    {
                        SkipSpecialEnemyTypes = true;
                    }
                    if (skipCharacterEnemySquads.Any(x => Squad.ElementHeaderText.ToLower().Contains(x.ToLower())) && !forceNoSkipCharacterEnemySquads.Any(x => Squad.ElementHeaderText.ToLower().Contains(x.ToLower())))
                    {
                        SkipCharacter = true;
                    }
                    if (rand.NextDouble() < settings.MakeHunterChance)
                    {
                        MakeHunter = true;
                    }
                }

                public void Randomize()
                {
                    
                    if (skipKeyWords.Any(x => Squad.ElementHeaderText.ToLower().Contains(x.ToLower())) && !forceNoSkipKeyWords.Any(x => Squad.ElementHeaderText.ToLower().Contains(x.ToLower())))
                    {
                        Debug.WriteLine("Skipping squad: " + Squad.ElementHeaderText);
                        return;
                    }
                    Debug.WriteLine("randomizing " + Squad.ElementHeaderText);
                    var team_element = GetField(Squad, "team");
                    var fireteams_block = GetField(Squad, "fire-teams");
                    foreach (TagFieldBlockElement fireteam in ((TagFieldBlock)fireteams_block).Elements)
                    {
                        var normal_diff_count_field = GetField(fireteam, "normal diff count");
                        ((TagFieldElementInteger)normal_diff_count_field).Data = (int)(((TagFieldElementInteger)normal_diff_count_field).Data * Settings.SquadSizeMultiplier);
                        RandomizeTypes(fireteam);
                        var starting_locations_block = GetField(fireteam, "starting locations");
                        foreach (TagFieldBlockElement starting_location in ((TagFieldBlock)starting_locations_block).Elements)
                        {
                            RandomizeTypes(starting_location);
                        }
                    }
                }

                // Randomizes the types for a fireteam or starting location
                private void RandomizeTypes(TagFieldBlockElement element)
                {
                    var character_field = GetField(element, "character type");
                    var weapon_field = GetField(element, "initial weapon");
                    var vehicle_field = GetField(element, "vehicle type");
                    TagField vehicle_variant_field;
                    TagField normal_diff_count;
                    // these have different names in fireteams and starting locations
                    if (FieldExists(element, "vehicle variant"))
                    { 
                        vehicle_variant_field = GetField(element, "vehicle variant"); 
                    }
                    else 
                    { 
                        vehicle_variant_field = GetField(element, "vehicle variant name"); 
                    }
                    if(FieldExists(element, "normal diff count"))
                    {
                        normal_diff_count = GetField(element, "normal diff count");
                    }
                    else
                    {
                        normal_diff_count = null;
                    }
                    var old_character = characters.List.Where(x => x.PaletteIndex == ((TagFieldBlockIndex)character_field).Value && ((TagFieldBlockIndex)character_field).Value != -1).FirstOrDefault();
                    if (old_character != null && !SkipCharacter)
                    {
                        var old_character_faction = old_character.Faction;
                        ((TagFieldEnum)TeamField).Value = (int)old_character_faction;
                        var new_character_factions = Settings.FactionCompatabilities.Where(x => x.Faction == old_character_faction).FirstOrDefault().CompatibleFactions;
                        if (new_character_factions.Contains(Faction.Covenant) && MakeHunter)
                        {
                            var new_character = characters.GetRandomObjectWeighted(Rand, require_palette_index: true, names: new List<string> { "hunter" });
                            if (new_character != null)
                            {
                                ((TagFieldBlockIndex)character_field).Value = new_character.PaletteIndex;
                                ((TagFieldBlockIndex)weapon_field).Value = -1;
                            }
                            
                        }
                        else
                        {
                            var new_character = characters.GetRandomObjectWeighted(Rand, require_palette_index: true, factions: new_character_factions);
                            ((TagFieldBlockIndex)character_field).Value = new_character.PaletteIndex;
                        }
                    }
                    if (((TagFieldBlockIndex)weapon_field).Value != -1)
                    {
                        ((TagFieldBlockIndex)weapon_field).Value = weapons.GetRandomObjectWeighted(Rand, require_palette_index: true).PaletteIndex;
                    }
                    if (((TagFieldBlockIndex)vehicle_field).Value != -1 && !SkipSpecialEnemyTypes)
                    {
                        HasVehicle = true;
                        var old_vehicle = vehicles.List.Where(x => x.PaletteIndex == ((TagFieldBlockIndex)vehicle_field).Value && ((TagFieldBlockIndex)vehicle_field).Value != -1).FirstOrDefault();
                        if (!(old_vehicle is null) && old_vehicle.SubCategory == SubCategory.Air)
                        {
                            ((TagFieldBlockIndex)vehicle_field).Value = vehicles.GetRandomObjectWeighted(Rand, require_palette_index: true, subcategories: new List<SubCategory>() { SubCategory.Air }).PaletteIndex;
                        }
                        else if (!(old_vehicle is null))
                        {
                            var new_vehicle = vehicles.GetRandomObjectWeighted(Rand, require_palette_index: true);
                            ((TagFieldBlockIndex)vehicle_field).Value = new_vehicle.PaletteIndex;
                            if (normal_diff_count != null && old_character != null)
                            {
                                //((TagFieldElementInteger)normal_diff_count).Data = (int)(new_vehicle.Seats * Settings.SquadSizeMultiplier);
                            }
                            var new_variant = new_vehicle.Variants.GetRandomObjectWeighted(Rand);
                            if (new_variant != null)
                            {
                                ((TagFieldElementStringID)vehicle_variant_field).Data = new_variant.Name;
                            }
                            else
                            {
                                ((TagFieldElementStringID)vehicle_variant_field).Data = "";
                            }
                        }
                    }
                    else if (Rand.NextDouble() < Settings.GiveVehicleChance && !SkipSpecialEnemyTypes && old_character != null)
                    {
                        var new_vehicle = vehicles.GetRandomObjectWeighted(Rand, require_palette_index: true);
                        ((TagFieldBlockIndex)vehicle_field).Value = new_vehicle.PaletteIndex;
                        if (normal_diff_count != null && old_character != null)
                        {
                            ((TagFieldElementInteger)normal_diff_count).Data = (int)(new_vehicle.Seats * Settings.SquadSizeMultiplier);
                            if (FieldExists(element, "seat type"))
                            {
                                var seat_field = GetField(element, "seat type");
                                //((TagFieldEnum)seat_field).Value = 0;
                            }
                        }
                        if (normal_diff_count != null && old_character != null)
                        {
                            //((TagFieldElementInteger)normal_diff_count).Data = (int)(new_vehicle.Seats * Settings.SquadSizeMultiplier);
                        }
                        var new_variant = new_vehicle.Variants.GetRandomObjectWeighted(Rand);
                        if (new_variant != null)
                        {
                            HasVehicle = true;
                            ((TagFieldBlockIndex)vehicle_field).Value = new_vehicle.PaletteIndex;
                            ((TagFieldElementStringID)vehicle_variant_field).Data = new_variant.Name;
                        }
                        else
                        {
                            ((TagFieldElementStringID)vehicle_variant_field).Data = "";
                        }
                    }
                }






                private void ClearSpawnPointsOverrides()
                {
                    var spawn_point_block = GetField(Squad, "spawn points");
                    foreach (TagFieldBlockElement spawn_point in ((TagFieldBlock)spawn_point_block).Elements)
                    {
                        var character_field = GetField(spawn_point, "character type");
                        ((TagFieldBlockIndex)character_field).Value = -1;
                        var weapon_field = GetField(spawn_point, "initial weapon");
                        ((TagFieldBlockIndex)weapon_field).Value = -1;
                        if (!SkipSpecialEnemyTypes)
                        {
                            var vehicle_field = GetField(spawn_point, "vehicle type");
                            if (vehicles.List.Any(x => x.PaletteIndex == ((TagFieldBlockIndex)vehicle_field).Value && ((TagFieldBlockIndex)vehicle_field).Value != -1))
                            {
                                old_vehicle = vehicles.List.Where(x => x.PaletteIndex == ((TagFieldBlockIndex)vehicle_field).Value).FirstOrDefault();
                                ((TagFieldBlockIndex)vehicle_field).Value = -1;
                            }
                            var seat_field = GetField(spawn_point, "seat type");
                            ((TagFieldEnum)seat_field).Value = 0;
                        }
                    }
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
