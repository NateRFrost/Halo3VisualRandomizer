# Halo3VisualRandomizer
An easy-to-use randomizer for Halo 3 on the Master Chief Collection (MCC).
<img width="1980" height="735" alt="image" src="https://github.com/user-attachments/assets/1dbbe47d-e98d-47f5-b1c9-aa94c95f4be1" />



# Requirements
- Halo 3 on MCC
- Halo 3 official mod tools (aka H3EK)
  - They can be downloaded via Steam https://store.steampowered.com/app/1695791/Halo_3_Mod_Tools__MCC/
 
# How to use
1. Consider backing up your installation of Halo 3 as the tool will overwrite it.
2. If you use the mod tools for other purposes, consider backing up any files you've edited as the tool will overwrite them
3. Start Halo3VisualRandomizer.exe
4. Configure your seed and other settings as you please (default settings recommended)
5. Make sure the MCC path and H3EK path matches what is on your computer.
     - You can check the path of each from your steam library by: right clicking -> manage -> browse local files
     - If you have your MCC installation across multiple locations, make sure it is the one where Halo 3 is installed.
6. Click start randomization. The first level takes 10+ minutes to finish randomizing. All levels finish randomizing in about 60 minutes.
7. Play! Make sure you boot MCC with anti-cheat off. You can play levels that have already been randomized if the subsequent level has also finished randomizing while you wait for the rest to randomize.

# FAQ
- What does this randomize?
  - Character types, the weapons held, if characters are in vehicles (no vehicle to vehicle only), the types of vehicles they use, weapons, vehicles, equipment and weapon crates, custscene dialogue, and cutscene model variants. Certain enemies that if randomized could softlock the game are not randomized. Flood infection forms are not randomized into to avoid glitches, but can still be spawned by flood tank forms and flood carrier forms.
- How likely is a softlock?
  - Pretty unlikely. You should expect to go through the game with no major issues. Once in a blue moon, an enemy you need to kill will be stuck in level geometry. If you get stuck, try looking around for enemies or backtracking and going back through a level without using a flying vehicle. If you are stuck in Crow's Nest after the elevator, there's an easy-to-miss enemy that won't always jump down from the windowed area that you'll need to look for (this issue also exists when not randomized).
- Can I play this online with friends?
  - Yes! If everyone runs the tool with the same settings and seed, you can play together. 
- Why does the randomizer take so long?
  - It builds and compiles each level from scratch using the offiical mod tools. This ensures that all objects are loaded into each level and made it drasticlly easier for me to code.
- Will you make randomizers for the other Halo games?
  - I already have one for Reach. I might make randomziers for ODST, or 4 as those are also compatible with this method of randomization.

 Huge thanks to Daniel McCluskey for laying the groundwork for this tool.
