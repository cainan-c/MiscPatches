﻿using BepInEx;
using BepInEx.Configuration;
using HarmonyLib;

namespace MiscPatches
{
    [BepInPlugin("com.swigz.miscpatches", "Misc Patches", "1.0")]
    public class Plugin : BaseUnityPlugin
    {
        public static ConfigEntry<bool> configOfflineSaveLoad;
        public static ConfigEntry<bool> configQuickRestart;
        public static ConfigEntry<bool> configQuickQuitSong;

        public static ConfigEntry<bool> configCustomShougou;
        public static ConfigEntry<string> configCustomShougouText;
        public static ConfigEntry<int> configCustomShougouLang;

        public static ConfigEntry<bool> configAddMechadon;

        public static ConfigEntry<bool> configMirrorMode;

        private void Awake()
        {

        configOfflineSaveLoad = Config.Bind("General.Patches",
                        "OfflineSaveLoad",
                        false,
                        "Loads local save files even when offline. Bypasses the log-in checks. Requires the FreeLocalSaves Plugin.");

        configQuickRestart = Config.Bind("General.Patches",
                        "QuickRestart",
                        false,
                        "Hit \"Backspace\" on your keyboard to quickly restart a song.");

        configQuickQuitSong = Config.Bind("General.Patches",
                        "QuickQuitSong",
                        false,
                        "Hit \"Escape\" on your keyboard to quickly quit a song and return to Song Select.");

        configCustomShougou = Config.Bind("General.CustomTitle",
                        "CustomShougou",
                        false,
                        "Enable the Custom Title Patch.");

        configCustomShougouText = Config.Bind("General.CustomTitle",
                        "CustomShougouText",
                        "",
                        "Set a Custom Title");

        configCustomShougouLang = Config.Bind("General.CustomTitle",
                        "CustomShougouLang",
                        1,
                        "Set the font to use.\nJp = 0\nEn,Fr,It,De,Es = 1\nTc = 2\nSc = 3\nKr = 4");

        configAddMechadon = Config.Bind("General.Patches",
                            "AddMechadon",
                            false,
                            "Adds Mecha-DON as a selectable costume in-game.");

        configMirrorMode = Config.Bind("General.Random",
                        "MirrorMode",
                        false,
                        "Flips everything around in Enso mode.");

            var instance = new Harmony("Misc Patches");

            if (Plugin.configOfflineSaveLoad.Value)
                instance.PatchAll(typeof(OfflineSaveLoad));

            if (Plugin.configQuickRestart.Value)
                instance.PatchAll(typeof(QuickRestart));

            if (Plugin.configQuickQuitSong.Value)
                instance.PatchAll(typeof(QuickQuitSong));

            if (Plugin.configCustomShougou.Value)
                instance.PatchAll(typeof(CustomShougou));

            if (Plugin.configAddMechadon.Value)
                instance.PatchAll(typeof(AddMechadon));

            if (Plugin.configMirrorMode.Value)
                instance.PatchAll(typeof(MirrorMode));

            // Plugin startup logic
            Logger.LogInfo($"Plugin {"com.swigz.miscpatches"} is loaded!");
        }
    }
}
