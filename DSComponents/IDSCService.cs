using DSComponents.Input.Models;
using System.Collections.Generic;

namespace DSComponents
{
	public interface IDSCService
	{
        public IEnumerable<DSCConfig> DSCInputConfigs { get; set; }

        public void CloseDropdowns();
    }
}
