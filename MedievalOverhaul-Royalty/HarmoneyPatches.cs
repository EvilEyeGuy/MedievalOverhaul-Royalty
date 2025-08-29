using HarmonyLib;
using Verse;

namespace MedievalOverhaulRoyalty
{
    [StaticConstructorOnStartup]
    public static class HarmonyPatches
    {
        static HarmonyPatches()
        {
            var harmony = new Harmony("medievaloverhaulroyalty.patches");
            if (MORMod.settings.patchEnabled)
            {
                PatchSequenceA(harmony);
            }
            else
            {
                PatchSequenceB(harmony);
            }
        }

        static void PatchSequenceA(Harmony harmony)
        {
            // Beispiel: Patch eine Methode
            // harmony.Patch(typeof(ZielKlasse).GetMethod("ZielMethode"), ...);
        }

        static void PatchSequenceB(Harmony harmony)
        {
            // Alternativer Patch
            // harmony.Patch(typeof(AndereKlasse).GetMethod("AndereMethode"), ...);
        }
    }
}