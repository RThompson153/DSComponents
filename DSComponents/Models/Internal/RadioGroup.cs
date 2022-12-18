using System.Collections.Generic;

namespace DSComponents
{
	public class RadioGroup
	{
		private Dictionary<string, bool> _options;
		internal string GroupName { get; set; }
		internal string SelectedValue { get; set; }
		internal Dictionary<string, bool> Options 
		{ 
			get => _options ?? new Dictionary<string, bool>();
			set => _options = value;
		}
	}
}
