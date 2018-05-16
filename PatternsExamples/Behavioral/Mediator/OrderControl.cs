namespace PatternsExamples.Behavioral.Mediator
{
	public class OrderControl : Colleague
	{
		public OrderControl(Mediator mediator) : base(mediator, "Order Button")
		{
		}

		public void Order(string item)
		{
			Changed(string.Format("Ordered item: {0}", item));
		}
	}
}
