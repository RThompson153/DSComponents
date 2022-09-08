using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSComponents.Input.Models
{
	public class DSCInputConfig
	{
		public DSCLabelConfig Label { get; set; }
		//public InputTypes Type { get; set; }
		public string Name {get;set;}
		public object Value { get; set; }
		public decimal? MinLength { get; set; }
		public decimal? MaxLength { get; set; }
		public double? Timeout { get; set; }
		public bool Multiple { get; set; }
		public bool Searchable { get; set; }
		public string FontSize {get;set;}
		public string TextColor { get; set; }
		public string BackgroundColor { get; set; } = "bg-white";
		public bool Error { get; set; }

		public bool Expanded {get;set;}
		public Dictionary<object, object> Items { get; set; }
	}
}
