using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsExamples.Behavioral.Iterator
{
	public class Customer
	{
		private List<Order> _orders;
		private int _index = 0;

		public Customer()
		{
			_orders = new List<Order>();
		}

		public void AddOrder(Order order)
		{
			_orders.Add(order);
		}

		public Order GetOrder()
		{
			return _orders[_index++];
		}

		public bool HasNext()
		{
			return _index != _orders.Count;
		}
	}
}
