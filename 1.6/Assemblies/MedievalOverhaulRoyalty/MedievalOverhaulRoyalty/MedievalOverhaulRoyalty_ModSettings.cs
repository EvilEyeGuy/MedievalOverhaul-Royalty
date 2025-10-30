using System.Collections.Generic;
using Verse;

namespace MedievalOverhaulRoyalty
{
    public class MedievalOverhaulRoyalty_ModSettings : ModSettings
    {
        public static HashSet<string> enabledSettings = new HashSet<string>();

        public override void ExposeData()
        {
            Scribe_Collections.Look(ref enabledSettings, "enabledSettings", LookMode.Value);
            base.ExposeData();
        }

        public static bool IsEnabled(string key)
        {
            return enabledSettings.Contains(key);
        }
    }
}
