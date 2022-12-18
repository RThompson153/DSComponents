using System.Collections.Generic;

namespace DSComponents
{
	public interface IDSCService
	{
        internal IEnumerable<DSCConfig> Dropdowns { get; set; }
        internal IEnumerable<RadioGroup> RadioGroups {get; set; }

        public void CloseDropdowns();
    }
}
