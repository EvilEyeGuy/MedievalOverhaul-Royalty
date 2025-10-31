using RimWorld;
using Verse;

namespace MedievalOverhaulRoyalty
{
    public static class MOR_ShowLetter
    {
        private const string DefName = "MOR_ModMenuNewsLetter";
        private const string TitleKey = "MOR_ModMenuNewsLetter_Title";
        private const string TextKey  = "MOR_ModMenuNewsLetter_Text";

        public static void TryShowOnce()
        {
            if (Current.Game == null)
            {
                Log.Message("[MOR] No game yet, skipping.");
                return;
            }

            var save = Current.Game.GetComponent<MOR_Save>();
            if (save == null)
            {
                save = new MOR_Save(Current.Game);
                Current.Game.components.Add(save);
                Log.Message("[MOR] Added MOR_Save component.");
            }

            if (save.shown)
            {
                Log.Message("[MOR] Letter already shown earlier.");
                return;
            }

            var def = DefDatabase<LetterDef>.GetNamedSilentFail(DefName) ?? LetterDefOf.NeutralEvent;
            string title = TitleKey.Translate();
            string text  = TextKey.Translate();

            Find.LetterStack.ReceiveLetter(title, text, def);
            save.shown = true;

            Log.Message("[MOR] Letter displayed and flag persisted.");
        }
    }
}
