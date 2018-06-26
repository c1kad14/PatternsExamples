using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsExamples.Behavioral.Observer
{
	public class SportResultNotifier
	{
		public List<Observer> Observers { get; set; } = new List<Observer>();

		public void ResultChanged(string result)
		{
			Console.WriteLine("Received new sport result {0}", result);
			Notify(result);
		}

		private void Notify(string info) => Observers.ForEach(o => o.ReceiveInfo(info));
	}
}
