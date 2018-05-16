using System;
using PatternsExamples.Behavioral.Mediator;

namespace PatternsExamples
{
	class Program
	{
		private static void Main(string[] args)
		{
			MediatorDemo();
		}


		#region Mediator

		private static void MediatorDemo()
		{
			Console.WriteLine("Hello World! This is presentation for mediator pattern");
			
			//Create mediator
			var mediator = new Mediator();

			//Create colleagues
			var search = new SearchControl(mediator);
			var view = new ViewControl(mediator);
			var order = new OrderControl(mediator);

			//To notify conrete colleague we need instantiate properties
			//uncomment next three lines of code with another commented code in files inside Mediator Folder(ColleagueControl.cs, Mediator.cs)
			//mediator.SearchControl = search;
			//mediator.ViewControl = view;
			//mediator.OrderControl = order;

			//invoking colleagues methods to notify others
			search.Search("iPhone");
			view.Display("iPhone X");
			order.Order("iPhone X Space Gray 64 GB");

			Console.WriteLine("End of the program.");
			Console.Read();
		}

		#endregion
	}
}
