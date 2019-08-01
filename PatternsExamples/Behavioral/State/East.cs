namespace PatternsExamples.Behavioral.State
{
    public class East : Direction
    {
	    public override Direction Right() => new South();

	    public override Direction Left() => new North();

	    public override string ToString() => "East Direction";
    }
}
