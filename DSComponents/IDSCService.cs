using DSComponents.Input.Models;
using System.Collections.Generic;

namespace DSComponents
{
	public interface IDSCService
	{
        public IEnumerable<DSCInputConfig> DSCInputConfigs { get; set; }

        public void CloseDropdowns();
    }
}
