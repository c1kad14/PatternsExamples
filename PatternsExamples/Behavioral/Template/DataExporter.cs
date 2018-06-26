using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace PatternsExamples.Behavioral.Template
{
	abstract class DataExporter
	{
		protected string data;
		protected virtual void Prepare() => Console.WriteLine("Preparation...");

		protected abstract void SetData();

		protected virtual void Send() => Console.WriteLine("Send data: {0}", data);
		public void Export()
		{
			Prepare();
			SetData();
			Send();
		}
	}
}
