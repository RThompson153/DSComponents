using System;

namespace DSComponents.Input.Models
{
	public class DSCInputAttribute : Attribute
	{
		public string Description;
		public bool Required;
		public string Type;
		public DSCInputAttribute(string type, string description, bool required)
		{
			Type = type;
			Description = description;
			Required = required;
		}
	}
}
