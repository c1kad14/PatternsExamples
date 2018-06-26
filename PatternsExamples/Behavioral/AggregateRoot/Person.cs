using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsExamples.Behavioral.AggregateRoot
{
	public class Person
	{
		private List<Address> _addresses;

		public Person()
		{
			_addresses = new List<Address>();
		}

		public string First { get; set; }
		public string Second { get; set; }

		public bool AddAddress(Address address)
		{
			if (address.Type == null)
			{
				return false;
			}
			foreach (var curent in _addresses)
			{
				if (curent.Type == address.Type)
				{
					return false;
				}
			}

			_addresses.Add(address);
			return true;
		}
	}
}
