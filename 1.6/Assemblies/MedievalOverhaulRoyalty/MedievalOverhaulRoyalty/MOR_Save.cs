using Verse;

namespace MedievalOverhaulRoyalty
{
    public class MOR_Save : GameComponent
    {
        public bool shown;

        public MOR_Save(Game game) { }

        public override void ExposeData()
        {
            Scribe_Values.Look(ref shown, "MOR_NewsShown", false);
        }
    }
}
