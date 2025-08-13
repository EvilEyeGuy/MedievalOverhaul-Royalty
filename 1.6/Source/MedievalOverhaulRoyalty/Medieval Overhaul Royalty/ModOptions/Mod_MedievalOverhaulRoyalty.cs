using UnityEngine;
using Verse;

namespace EEGRoyalty
{
    public class Mod_EEGRoyalty : Mod
    {
        public static ModSettings_EEGRoyalty settings;

        public Mod_EEGRoyalty(ModContentPack content) : base(content)
        {
            settings = GetSettings<ModSettings_EEGRoyalty>();
        }

        public override string SettingsCategory()
        {
            return "EEGRoyalty_Title".Translate();
        }
        public override void DoSettingsWindowContents(Rect inRect)
        {
            settings.DoSettingsWindowContents(inRect);
        }

    }
}
