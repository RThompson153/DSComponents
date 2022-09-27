using System.Collections.Generic;

namespace DSComponents.Input.Models
{
	public class DSCInputConfig
	{
		[DSCInputAttribute("DSCLabelConfig", "Label for the component.", false)]
		public DSCLabelConfig Label { get; set; }

		[DSCInputAttribute("string", "Name of the component.", false)]
		public string Name { get; set; }
		
		[DSCInputAttribute("string", "Placeholder for input components.", false)]
		public string Placeholder { get; set; }
		
		[DSCInputAttribute("decimal", "The minimum number of items that can be selected.", false)]
		public decimal? Minimum { get; set; }
		
		[DSCInputAttribute("decimal", "The maximum number of items that can be selected.", false)]
		public decimal? Maximum { get; set; }
		
		[DSCInputAttribute("double", "Timeout value.", false)]
		public double? Timeout { get; set; }
		
		[DSCInputAttribute("bool", "If true, multiple items can be selected.", false)]
		public bool Multiple { get; set; }
		
		[DSCInputAttribute("bool", "If true, the items can be searched and filtered.", false)]
		public bool Searchable { get; set; }
		
		[DSCInputAttribute("string", "CSS class for the component text color. Bootstrap classes are supported.", false)]
		public string TextColor { get; set; } = "text-dark";
		
		[DSCInputAttribute("string", "CSS class for the component background color. Bootstrap classes are supported.", false)]
		public string BackgroundColor { get; set; } = "bg-white";
		
		[DSCInputAttribute("bool", "Expanded state.", false)]
		public bool Expanded { get; set; }
		
		[DSCInputAttribute("bool", "If true, the component is disabled.", false)]
		public bool Disabled { get; set; }
		
		[DSCInputAttribute("object", "The collection of selectable items.", true)]
		public List<object> SelectItems { get; set; }

		public bool Error { get; set; }
		public List<object> SelectValues { get; set; } = new();
	}
}
