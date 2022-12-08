using System.Collections.Generic;

namespace DSComponents
{
	public interface IDSCService
	{
        protected internal IEnumerable<DSCConfig> DSCInputConfigs { get; set; }

        public void CloseDropdowns();
    }
}
