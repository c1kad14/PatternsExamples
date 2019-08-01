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
