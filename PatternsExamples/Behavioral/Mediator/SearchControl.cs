namespace PatternsExamples.Behavioral.Mediator
{
	public class SearchControl : Colleague
	{
		public SearchControl(Mediator mediator) : base(mediator, "Search Button")
		{
		}

		public void Search(string searchItem)
		{
			Changed(string.Format("Performed search for: {0}", searchItem));
		}
	}
}
