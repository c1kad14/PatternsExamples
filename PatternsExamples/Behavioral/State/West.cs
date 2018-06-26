using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsExamples.Behavioral.State
{
    class West : Direction
    {
	    public override Direction Right() => new North();

	    public override Direction Left() => new South();
	    public override string ToString() => "West Direction";
	}
}
