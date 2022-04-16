using HarmonyLib;


namespace MiscPatches
{
    public class AddMechadon
    {
        [HarmonyPatch(typeof(DonCosDataInterface))]
        [HarmonyPatch(MethodType.Constructor)]
        [HarmonyPatch(new[] { typeof(string)})]
        [HarmonyPostfix]
        private static void DonCosDataInterface_Postfix(DonCosDataInterface __instance, string path)
        {   
            var DonInfoAccessors = __instance.donCosInfoAccessers;

            DonInfoAccessors.Add(new DonCosDataInterface.DonCosInfoAccesser(999, "mechadon", 999000, 0, -1, -1, -1, 4000, true));
        }
    }
}