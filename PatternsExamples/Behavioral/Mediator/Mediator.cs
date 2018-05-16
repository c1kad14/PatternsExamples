namespace PatternsExamples.Behavioral.Mediator
{
	public delegate void ControlInvokedEventHandler(string text);

	public class Mediator
	{
		public event ControlInvokedEventHandler ControlInvokedEvent;

		//Methid that will notify all subscribed colleagues
		public void ControlInvoked(string text)
		{
			ControlInvokedEvent?.Invoke(text);
		}

		//uncomment this part with other commented part of code
		//to be able to notify specified colleague
		//public void ControlInvoked(string text, ColleagueControl from)
		//{
		//	if (from is SearchControl)
		//	{
		//		ViewControl?.ColleagueControlCallback(text);
		//	}
		//	else if (from is ViewControl)
		//	{
		//		OrderControl?.ColleagueControlCallback(text);
		//	}
		//	else if (from is OrderControl)
		//	{
		//		SearchControl?.ColleagueControlCallback(text);
		//	}
		//}

		//public SearchControl SearchControl { get; set; }
		//public ViewControl ViewControl { get; set; }
		//public OrderControl OrderControl { get; set; }

	}
}
