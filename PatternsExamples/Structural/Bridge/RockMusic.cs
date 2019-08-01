using System;

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
