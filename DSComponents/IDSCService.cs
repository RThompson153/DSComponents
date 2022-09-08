using DSComponents.Input.Models;

namespace DSComponents
{
	public interface IDSCService
	{
		public IEnumerable<DSCInputConfig> DSCInputConfigs { get; set; }
		public void CloseDropdowns();
	}
}
