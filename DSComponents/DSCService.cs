using System.Collections.Generic;
using System.Linq;

namespace DSComponents
{
	public class DSCService : IDSCService
	{
        private IEnumerable<DSCConfig> _dropdowns;
        private IEnumerable<RadioGroup> _radioGroups;
        public IEnumerable<DSCConfig> Dropdowns
        {
            get => _dropdowns ?? new List<DSCConfig>();
            set => _dropdowns = value;
        }

        public IEnumerable<RadioGroup> RadioGroups
        {
            get => _radioGroups ?? new List<RadioGroup>();
            set => _radioGroups = value;
		}

        public void CloseDropdowns()
        {
            if (Dropdowns.Any(dsci => dsci.Expanded))
            {
                foreach (var dsci in Dropdowns)
                    dsci.Expanded = false;
            }
        }
    }
}
