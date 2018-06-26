using System;
using System.Collections.Generic;
using System.Text;

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
