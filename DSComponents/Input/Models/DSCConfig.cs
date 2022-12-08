using DSComponents.Enums;
using System.Collections.Generic;

namespace DSComponents
{
	public class DSCConfig
	{
		[DSCConfigAttribute("DSCLabelConfig", "Label for the component.", false)]
		public DSCLabelConfig Label { get; set; }

		[DSCConfigAttribute("string", "Name of the component.", false)]
		public string Name { get; set; }
		
		[DSCConfigAttribute("string", "Placeholder for input components.", false)]
		public string Placeholder { get; set; }
		
		[DSCConfigAttribute("decimal", "The minimum number of items that can be selected.", false)]
		public double? Minimum { get; set; }
		
		[DSCConfigAttribute("decimal", "The maximum number of items that can be selected.", false)]
		public double? Maximum { get; set; }
		
		[DSCConfigAttribute("double", "Timeout value.", false)]
		public double? Timeout { get; set; }
		
		[DSCConfigAttribute("bool", "If true, multiple items can be selected.", false)]
		public bool Multiple { get; set; }
		
		[DSCConfigAttribute("bool", "If true, the items can be searched and filtered.", false)]
		public bool Searchable { get; set; }
		
		[DSCConfigAttribute("bool", "Expanded state.", false)]
		public bool Expanded { get; set; }
		
		[DSCConfigAttribute("bool", "If true, the component is disabled.", false)]
		public bool Disabled { get; set; }
		
		[DSCConfigAttribute("object", "The collection of selectable items.", true)]
		public List<object> SelectItems { get; set; }

		[DSCConfigAttribute("NumericType", "Type a numerical value needs to be parsed to.", false)]
		public NumericType NumericType { get; set; }
		[DSCConfigAttribute("CheckboxType", "Type of a checkbox.", false)]
		public CheckboxType CheckboxType {get;set;}

		public bool Error { get; set; }
		public List<object> SelectValues { get; set; } = new();
	}
}
