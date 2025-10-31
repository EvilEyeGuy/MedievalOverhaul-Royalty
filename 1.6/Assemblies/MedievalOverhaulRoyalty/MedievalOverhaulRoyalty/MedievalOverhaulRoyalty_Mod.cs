using UnityEngine;
using Verse;
using RimWorld;

namespace MedievalOverhaulRoyalty
{
    public class MedievalOverhaulRoyalty_Mod : Mod
    {
        private MedievalOverhaulRoyalty_ModSettings settings;

        public MedievalOverhaulRoyalty_Mod(ModContentPack content) : base(content)
        {
            settings = GetSettings<MedievalOverhaulRoyalty_ModSettings>();
        }

        public override void DoSettingsWindowContents(Rect inRect)
        {
            Listing_Standard list = new Listing_Standard();
            list.Begin(inRect);

            DrawToggleSetting(list, "EEG_RoyaltyTitle");
            list.GapLine();
            DrawToggleSetting(list, "EEG_RoyaltyTrader");

            list.End();
        }

        private void DrawToggleSetting(Listing_Standard list, string key)
        {
            bool enabled = MedievalOverhaulRoyalty_ModSettings.enabledSettings.Contains(key);

            string label = (key + "_Label").Translate();
            string desc = (key + "_Desc").Translate();

            Text.Font = GameFont.Medium;
            list.CheckboxLabeled(label, ref enabled);
            Text.Font = GameFont.Small;

            if (!string.IsNullOrEmpty(desc))
            {
                list.Label(desc);
                list.Gap(6f);
            }

            if (enabled)
                MedievalOverhaulRoyalty_ModSettings.enabledSettings.Add(key);
            else
                MedievalOverhaulRoyalty_ModSettings.enabledSettings.Remove(key);
        }

        public override string SettingsCategory()
        {
            return "Medieval Overhaul Royalty";
        }
    }
}
