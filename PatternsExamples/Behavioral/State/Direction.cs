using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsExamples.Behavioral.State
{
    public abstract class Direction
    {
	    public abstract Direction Right();
	    public abstract Direction Left();
    }
}
