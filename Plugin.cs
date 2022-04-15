using BepInEx;
using BepInEx.IL2CPP;
using BepInEx.Configuration;
using HarmonyLib;

namespace MiscPatches
{
    [BepInPlugin("com.swigz.miscpatches", "Misc Patches", "1.0")]
    public class Plugin : BasePlugin
    {
        public static ConfigEntry<bool> configOfflineSaveLoad;
        public static ConfigEntry<bool> configQuickRestart;
        public static ConfigEntry<bool> configQuickQuitSong;

        public static ConfigEntry<bool> configCustomShougou;
        public static ConfigEntry<string> configCustomShougouText;
        public static ConfigEntry<int> configCustomShougouLang;
        public override void Load()
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


            var instance = new Harmony("Misc Patches");

            if (Plugin.configOfflineSaveLoad.Value)
                instance.PatchAll(typeof(OfflineSaveLoad));

            if (Plugin.configQuickRestart.Value)
                instance.PatchAll(typeof(QuickRestart));

            if (Plugin.configQuickQuitSong.Value)
                instance.PatchAll(typeof(QuickQuitSong));

            if (Plugin.configQuickQuitSong.Value)
                instance.PatchAll(typeof(CustomShougou));



        // Plugin startup logic
        Log.LogInfo($"Plugin {"com.swigz.miscpatches"} is loaded!");
        }
    }
}
