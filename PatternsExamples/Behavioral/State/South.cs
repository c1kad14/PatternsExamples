using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsExamples.Behavioral.State
{
    class South : Direction
    {
	    public override Direction Right() => new West();

	    public override Direction Left() => new East();
	    public override string ToString() => "South Direction";
	}
}
