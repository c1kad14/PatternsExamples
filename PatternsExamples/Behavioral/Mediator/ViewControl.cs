namespace PatternsExamples.Behavioral.Mediator
{
	public class ViewControl : ColleagueControl
	{
		public ViewControl(Mediator mediator) : base(mediator, "View Button")
		{
		}

		public void Display(string item)
		{
			Changed(string.Format("Display item: {0}", item));
		}
	}
}
