using System.Collections.Generic;
using System.Linq;

namespace DSComponents
{
	public class DSCService : IDSCService
	{
        private IEnumerable<DSCConfig> _dscInputConfigs;
        public IEnumerable<DSCConfig> DSCInputConfigs
        {
            get => _dscInputConfigs ?? new List<DSCConfig>();
            set => _dscInputConfigs = value;
        }

        public void CloseDropdowns()
        {
            if (DSCInputConfigs.Any(dsci => dsci.Expanded))
            {
                foreach (var dsci in DSCInputConfigs)
                    dsci.Expanded = false;
            }
        }
    }
}
