# BaseSkinSwapperBuilder

Editor addon that generates implementations that patch a CharacterSpawnCard's loadout to use the applied skin
main use case is so allies/monsters use the designated skin. 

Shoutout to **Orbital** For Helping test this.

## Prerequisite

1. [SkinBuilder](https://github.com/KingEnderBrine/RoRSkinBuilder)
2. [SkinBuilderExtension](https://github.com/RuneFox237/RoRSkinBuilderExtension)

## How to Use

1. Make a skin as per usual via [SkinBuilder](https://github.com/KingEnderBrine/RoRSkinBuilder). Use this Doc as a [guide](https://docs.google.com/document/d/1RCs9pJUEk-0j9X95VpSgqHlCwHbHEcP97ix0ebCAEvM/edit?tab=t.0) (its really well documented ngl)
2. Setup SkinBuilderExtension
    
    2.1. add 2 Empty gameobjects in a scene  
      ![](https://files.catbox.moe/hoxla4.png)
      ```
        gameobject with SkinBuilder Extension Component, this is basically the head to all extensions
        gameobject to hold BaseSkinSwapperInfo Component 
      ```
    2.2 Set BaseSkinSwapperInfo Component as so; then Click **Build**
        ![](https://files.catbox.moe/23ukyf.png) 

    2.3. Set the SkinBuilder Extension Component as so;
    Then Click **Build** (yes due to how Base Extension is setup, you need to click multiple Build Buttons)
        ![](https://files.catbox.moe/fe5xi1.png)

3. Then **Build** With the ModInfo from the SkinBuilder, then hopefully it loads in-game.

## How to Debug

although this extension isnt bulletproof it should be rare to cause any issues.

if it did happen to make u unable to compile youre dll, try heading to **SkinMods** in your assets Folder, Look for your the folder with the mod name then purging **[...]BaseSkinSwapper.cs** & **[...]ModInfoExtension.cs**. after that remove SkinBuilderExtension Componenent's Entry for This Extension. that should clean this extension from your skin mod without needing to delete everything.
