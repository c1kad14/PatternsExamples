using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsExamples.Creational.Factory
{
	public class ModelA : IModel
	{
		public string GetModelName()
		{
			return "Hello I'm Model A";
		}
	}
}
