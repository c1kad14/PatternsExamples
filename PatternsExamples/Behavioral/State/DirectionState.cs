namespace PatternsExamples.Behavioral.State
{
    class DirectionState : IDirectionState
    {
	    public Direction State { get; set; }

	    public DirectionState(Direction direction)
	    {
		    State = direction;
	    }

	    public void Left()
	    {
		    State = State.Left();
	    }

	    public void Right()
	    {
		    State = State.Right();
	    }

	    public override string ToString() => State.ToString();
    }
}
