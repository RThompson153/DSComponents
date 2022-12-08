using System;

namespace DSComponents
{
	public class DSCConfigAttribute : Attribute
	{
		public string Description;
		public bool Required;
		public string Type;
		public DSCConfigAttribute(string type, string description, bool required)
		{
			Type = type;
			Description = description;
			Required = required;
		}
	}
}
