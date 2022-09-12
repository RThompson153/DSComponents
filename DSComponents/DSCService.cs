using DSComponents.Input.Models;
using System.Collections.Generic;
using System.Linq;

namespace DSComponents
{
	public class DSCService : IDSCService
	{
		private IEnumerable<DSCInputConfig> _dscInputConfigs;
		public IEnumerable<DSCInputConfig> DSCInputConfigs 
		{ 
			get => _dscInputConfigs ?? new List<DSCInputConfig>();
			set => _dscInputConfigs = value;		
		}

		public void ToggleDropdown(bool expanded, DSCInputConfig item)
		{
			foreach (var dsci in DSCInputConfigs)
				dsci.Expanded = false;

			item.Expanded = expanded;
		}

		public void CloseDropdowns()
		{
			if(DSCInputConfigs.Any(dsci => dsci.Expanded))
			{
				foreach(var dsci in DSCInputConfigs)
					dsci.Expanded = false;
			}
		}
	}
}
