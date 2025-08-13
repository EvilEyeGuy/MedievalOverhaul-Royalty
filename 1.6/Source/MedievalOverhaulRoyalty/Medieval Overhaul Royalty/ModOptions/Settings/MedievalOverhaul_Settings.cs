using UnityEngine;
using Verse;
using MedievalOverhaul;

namespace EEGRoyalty
{
    public class ModSettings_EEGRoyalty : ModSettings
    {
        // These settings are used with the patch operation
        public bool EEG_RoyaltyTitle = true;

        // All fields need to be added to here so that they are properly saved
        public override void ExposeData()
        {
            Scribe_Values.Look(ref EEG_RoyaltyTitle, "EEG_RoyaltyTitle", true);
            base.ExposeData();
        }
        private Vector2 scrollPosition;
        public void DoSettingsWindowContents(Rect inRect)
        {
            Rect rect = new Rect(inRect.x, inRect.y, inRect.width, inRect.height);
            float scrollHeight = 500f;
            Rect viewRect = new Rect(rect.x, rect.y, rect.width - 16f, scrollHeight);
            Widgets.BeginScrollView(rect, ref scrollPosition, viewRect);
            Listing_Standard options = new Listing_Standard();
            options.Begin(rect);
            options.Gap();
            options.CheckboxLabeled("EEG_Settings_RoyaltyTitle".Translate(), ref EEG_RoyaltyTitle, "EEG_Settings_RoyaltyTitle_Tooltip".Translate());
            options.Gap();
            options.GapLine();
            options.Gap();
            if (options.ButtonText("Reset to Defaults"))
            {
                ResetSettingsToDefault();
            }
            options.End();
            Widgets.EndScrollView();
        }

        // All new toggle fields need to be added here and set equal to their default intended value
        // This is so the reset to default button will work properly
        public void ResetSettingsToDefault()
        {
            EEG_RoyaltyTitle = true;
        }

    }
}