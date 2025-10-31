using HarmonyLib;
using Verse;
using RimWorld;

namespace MedievalOverhaulRoyalty
{
    [StaticConstructorOnStartup]
    public static class MOR_Harmony
    {
        static MOR_Harmony()
        {
            var h = new Harmony("MOR.NewsOnce");
            h.PatchAll();
            Log.Message("[MOR] Harmony patched.");
        }
    }

    [HarmonyPatch(typeof(GameComponentUtility), nameof(GameComponentUtility.StartedNewGame))]
    public static class Patch_StartedNewGame
    {
        static void Postfix()
        {
            Log.Message("[MOR] StartedNewGame Postfix");
            MOR_ShowLetter.TryShowOnce();
        }
    }

    [HarmonyPatch(typeof(GameComponentUtility), nameof(GameComponentUtility.LoadedGame))]
    public static class Patch_LoadedGame
    {
        static void Postfix()
        {
            Log.Message("[MOR] LoadedGame Postfix");
            MOR_ShowLetter.TryShowOnce();
        }
    }
}
