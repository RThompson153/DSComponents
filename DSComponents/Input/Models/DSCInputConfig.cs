using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSComponents.Input.Models
{
	public class DSCInputConfig
	{
		public Guid Id {get;set;}
		public DSCLabelConfig Label { get; set; }
		public string Name { get; set; }
		public List<object> Value { get; set; } = new();
		public decimal? Minimum { get; set; }
		public decimal? Maximum { get; set; }
		public double? Timeout { get; set; }
		public bool Multiple { get; set; }
		public bool Searchable { get; set; }
		public string TextColor { get; set; } = "text-dark";
		public string BackgroundColor { get; set; } = "bg-white";
		public bool Error { get; set; }
		public bool Expanded { get; set; }
		public bool Disabled { get; set; }
		public bool HasFocus { get; set; }
		public List<object> SelectItems { get; set; }
	}
}
