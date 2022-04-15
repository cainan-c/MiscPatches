using HarmonyLib;


namespace MiscPatches
{
    public class CustomShougou
    {
        [HarmonyPatch(typeof(WordDataInterface))]
        [HarmonyPatch(MethodType.Constructor)]
        [HarmonyPatch(new[] { typeof(string), typeof(string) })]
        [HarmonyPostfix]
        private static void WordDataInterface_Postfix(WordDataInterface __instance, string path, string language)
        {   
            var TextInfoAccessors = __instance.wordListInfoAccessers;

            string shougouKey = "shougou_000";
            string shougouText = Plugin.configCustomShougouText.Value;
            int fontType = Plugin.configCustomShougouLang.Value;

            TextInfoAccessors.Insert(0, new WordDataInterface.WordListInfoAccesser(shougouKey, shougouText, fontType));
            TextInfoAccessors.Insert(0, new WordDataInterface.WordListInfoAccesser("customize_shougou_blank", "Custom Title: "+shougouText, fontType));
            //TextInfoAccessors.Insert(0, new WordDataInterface.WordListInfoAccesser("customize_shougou_blank_description", "Current Custom Title: "+shougouText, fontType));
        }
    }
}