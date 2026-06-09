using System.Collections.Generic;
using System.Xml;
using Verse;

namespace MedievalOverhaulRoyalty
{
    public class PatchOperation_ToggleSettings : PatchOperation
    {
        public List<string> settings;
        public PatchOperation active;
        public PatchOperation inactive;

        protected override bool ApplyWorker(XmlDocument xml)
        {
            bool anyActive = false;

            foreach (var setting in settings)
            {
                if (MedievalOverhaulRoyalty_ModSettings.IsEnabled(setting))
                {
                    anyActive = true;
                    break;
                }
            }

            if (anyActive && active != null)
            {
                return active.Apply(xml);
            }
            else if (!anyActive && inactive != null)
            {
                return inactive.Apply(xml);
            }

            return true;
        }
    }
}
