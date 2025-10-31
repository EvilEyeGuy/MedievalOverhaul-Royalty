using System.Linq;
using Verse;

namespace MedievalOverhaulRoyalty
{
    [StaticConstructorOnStartup]
    public static class MOR_Bootstrap
    {
        static MOR_Bootstrap()
        {
            // Runs after a save is loaded or a new game is started
            LongEventHandler.QueueLongEvent(EnsureComponent, "LibraryStartup", false, null);
        }

        private static void EnsureComponent()
        {
            if (Current.Game == null) return;

            var comps = Current.Game.components;
            if (comps == null) return;

            var existing = comps.OfType<MedievalOverhaulRoyalty_NewsLetter>().FirstOrDefault();
            if (existing == null)
            {
                var added = new MedievalOverhaulRoyalty_NewsLetter(Current.Game);
                comps.Add(added);
                added.FinalizeInit(); // ensure immediate show and persistence
            }
        }
    }
}
