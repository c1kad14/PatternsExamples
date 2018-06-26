using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsExamples.Behavioral.State
{
    class North : Direction
    {
	    public override Direction Right() => new East();

	    public override Direction Left() => new West();
	    public override string ToString() => "North Direction";
	}
}
