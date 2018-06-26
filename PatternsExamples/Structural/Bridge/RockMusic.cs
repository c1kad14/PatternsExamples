using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsExamples.Structural.Bridge
{
	class RockMusic : ICanSing
	{
		public void MakeSomeNoise()
		{
			Console.WriteLine("Nothnig else matters");
		}
	}
}
