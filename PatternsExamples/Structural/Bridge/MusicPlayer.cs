using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsExamples.Structural.Bridge
{
	class MusicPlayer
	{
		public ICanSing CanSing { get; set; }

		public void Play()
		{
			CanSing?.MakeSomeNoise();
		}
	}
}
