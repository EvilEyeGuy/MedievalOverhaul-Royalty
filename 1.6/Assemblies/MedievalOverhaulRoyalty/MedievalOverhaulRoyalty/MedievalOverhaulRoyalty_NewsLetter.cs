using RimWorld;
using Verse;

namespace MedievalOverhaulRoyalty
{
    public class MedievalOverhaulRoyalty_NewsLetter : GameComponent
    {
        private bool shown;

        public MedievalOverhaulRoyalty_NewsLetter(Game game) { }

        public override void FinalizeInit()
        {
            if (shown) return;
            shown = true;
        }

        public override void ExposeData()
        {
            Scribe_Values.Look(ref shown, "MOR_NewsShown", false);
        }
    }
}
