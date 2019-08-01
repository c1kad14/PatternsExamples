using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using PatternsExamples.Behavioral.AggregateRoot;
using PatternsExamples.Behavioral.Iterator;
using PatternsExamples.Behavioral.Mediator;
using PatternsExamples.Behavioral.Observer;
using PatternsExamples.Behavioral.State;
using PatternsExamples.Behavioral.Template;
using PatternsExamples.Creational.Factory;
using PatternsExamples.Structural.Adapter;
using PatternsExamples.Structural.Bridge;

namespace PatternsExamples
{
	class Program
	{
		private static void Main(string[] args)
		{
			//MediatorDemo();
			//AggregateRootDemo();
			//IteratorDemo();
			//IteratorIEnumerableDemo();
			//ObserverDemo();
			//StateDemo();
			//AdapterDemo();
			//BridgeDemo();
			//TemplateDemo();
			FactoryDemo();
			Console.ReadLine();
		}

		#region Behavioral

		#region Mediator

		/// <summary>
		/// Mediator pattern helps us to provide connect independent objects, to be aware in each others changes
		/// </summary>
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

		#region Aggregate Root

		/// <summary>
		/// Aggreegate root pattern gives us posibility to add only unique values to our collection
		/// F.E. Only one address type can be present in persons address list
		/// </summary>
		private static void AggregateRootDemo()
		{
			var person = new Person
			{
				First = "John",
				Second = "Smith"
			};

			person.AddAddress(new Address() {City = "New York", Street = "52 Street", Type = AddressType.Home});
			person.AddAddress(new Address()
				{City = "New York", Street = "60 Street", Type = AddressType.Home}); // this address wont be added
		}

		#endregion

		#region Iterator

		/// <summary>
		/// Iterator pattern gives us possibility for our class to be iteratable. Usually it's needed together with Aggregate Root.
		/// In .NET IEnumartor interface declares all needable method's
		/// To be possible our class to be used in foreach loop it's required to implement IEnumerable interface (see IteratorIEnumerableDemo)
		/// </summary>
		private static void IteratorDemo()
		{
			var customer = new Customer();
			customer.AddOrder(new Order() {OrderId = "1", Item = "Phone"});
			customer.AddOrder(new Order() {OrderId = "2", Item = "Watch"});
			customer.AddOrder(new Order() {OrderId = "3", Item = "TV"});
			customer.AddOrder(new Order() {OrderId = "4", Item = "Radio"});

			while (customer.HasNext())
			{
				Console.WriteLine(customer.GetOrder().OrderId);
			}
		}


		private static void IteratorIEnumerableDemo()
		{
			var orders = new OrdersList(new Order[]
			{
				new Order
				{
					Item = "Phone", OrderId = "1"
				},
				new Order
				{
					Item = "Watch", OrderId = "2"
				},
				new Order
				{
					Item = "TV", OrderId = "3"
				},
			});

			foreach (var order in orders)
			{
				Console.WriteLine(order.OrderId);
			}

			foreach (var order in orders)
			{
				Console.WriteLine(order.OrderId);
			}
		}

		#endregion

		#region Observer

		public static void ObserverDemo()
		{
			var notifier = new SportResultNotifier();
			var observer = new Observer() {Name = "John"};
			notifier.Observers.Add(observer);
			notifier.Observers.Add(new Observer() {Name = "Tony"});
			notifier.Observers.Add(new Observer() {Name = "Samantha"});
			notifier.ResultChanged("Jamaica wins Brasil");
			notifier.ResultChanged("Argentina looses Croatia");
			notifier.Observers.Remove(observer);
			notifier.ResultChanged("smth happened");
		}

		#endregion

		#region State

		/// <summary>
		/// State pattern helps to save state of an object and change the behavior related to the current state
		/// Easy extensible when new States appear
		/// Main elements of State pattern: context (DirectionState), state base(Direction) and concrete state(East, West etc)
		/// </summary>
		public static void StateDemo()
		{
			var context = new DirectionState(new South());
			Console.WriteLine(context);
			context.Left();
			Console.WriteLine(context);
			context.Left();
			Console.WriteLine(context);
			context.Left();
			Console.WriteLine(context);
			context.Left();
			Console.WriteLine(context);
			context.Right();
			Console.WriteLine(context);
			context.Left();
			Console.WriteLine(context);
		}

		#endregion

		#region Template

		private static void TemplateDemo()
		{
			DataExporter exporter = new SportResultsExporter();
			exporter.Export();
			exporter = new PoliticsDataExporter();
			exporter.Export();
		}

		#endregion

		#endregion

		#region Structural

		#region Adapter

		private static void AdapterDemo()
		{
			ITarget target = new VendorAdapter();
			foreach (var product in target.GetProducts())
			{
				Console.WriteLine(product);
			}
		}

		#endregion

		#region Bridge

		public static void BridgeDemo()
		{
			var player = new MusicPlayer();
			player.Play();
			player.CanSing = new RapMusic();
			player.Play();
			player.CanSing = new RockMusic();
			player.Play();
		}

		#endregion

		#endregion

		#region Creational

		#region Factory

		private static void FactoryDemo()
		{
			var factory = new ModelFactory();
			Console.WriteLine(factory.GetModel<ModelA>().GetModelName());
			Console.WriteLine(factory.GetModel<ModelB>().GetModelName());
		}

		#endregion

		#endregion
	}
}