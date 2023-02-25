using System;
namespace DemoMVC.CustomAttribute
{
	[AttributeUsage(AttributeTargets.Class|AttributeTargets.Method)]
	public class DemoAttribute: Attribute
	{
		public string test = "ok";
		public DemoAttribute(string msg)
		{
			Console.WriteLine(msg);
		}
	}
}

