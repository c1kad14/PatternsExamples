namespace PatternsExamples.Behavioral.State
{
	public interface IDirectionState
	{
		Direction State { get; set; }
		void Left();
		void Right();
	}
}
