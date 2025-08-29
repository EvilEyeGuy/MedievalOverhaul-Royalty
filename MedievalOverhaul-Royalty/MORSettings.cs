using Verse;
using UnityEngine;

namespace MedievalOverhaulRoyalty
{
    public class MORSettings : ModSettings
    {
        public bool patchEnabled = true;

        public override void ExposeData()
        {
            Scribe_Values.Look(ref patchEnabled, "patchEnabled", true);
            base.ExposeData();
        }
    }

    public class MORMod : Mod
    {
        public static MORSettings settings;

        public MORMod(ModContentPack content) : base(content)
        {
            settings = GetSettings<MORSettings>();
        }

        public override void DoSettingsWindowContents(Rect inRect)
        {
            Listing_Standard listingStandard = new Listing_Standard();
            listingStandard.Begin(inRect);
            listingStandard.CheckboxLabeled("Patch aktivieren (PatchSequenceA)", ref settings.patchEnabled);
            listingStandard.End();
        }

        public override string SettingsCategory()
        {
            return "Medieval Overhaul Royalty";
        }
    }
}