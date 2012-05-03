using System;
using Nancy;

namespace MonoNancy
{
	public class RootModule: NancyModule
	{
		public RootModule ()
		{
			this.Get["/"] = _ => "Nancy FX running on Mono";
		}
	}
}

