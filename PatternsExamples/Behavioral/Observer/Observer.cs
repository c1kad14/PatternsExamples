using System;

namespace PatternsExamples.Behavioral.Observer
{
	public class Observer
	{
		public string Name { get; set; }
		public void ReceiveInfo(string info)
		{
			Console.WriteLine("Observer {0} received info about: {1}", Name, info);
		}

	}
}
