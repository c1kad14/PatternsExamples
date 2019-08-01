using System;

namespace PatternsExamples.Structural.Bridge
{
    class RapMusic : ICanSing
    {
	    public void MakeSomeNoise()
	    {
		    Console.WriteLine("Loose yourself...");
	    }
    }
}
