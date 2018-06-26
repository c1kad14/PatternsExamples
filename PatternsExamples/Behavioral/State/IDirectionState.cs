using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsExamples.Behavioral.State
{
	public interface IDirectionState
	{
		Direction State { get; set; }
		void Left();
		void Right();
	}
}
