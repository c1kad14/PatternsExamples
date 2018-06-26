using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PatternsExamples.Behavioral.Iterator
{
	public class OrdersList : IEnumerable<Order>
	{
		private OrdersEnumerator enumerator;

		public OrdersList(Order[] _orders)
		{
			enumerator = new OrdersEnumerator(_orders);
		}

		public IEnumerator<Order> GetEnumerator()
		{
			enumerator.Reset();
			return enumerator;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		private class OrdersEnumerator : IEnumerator<Order>
		{
			private readonly Order[] _orders;
			private int _index;

			public OrdersEnumerator(Order[] orders)
			{
				_orders = new Order[orders.Length];
				_orders = orders;
				_index = -1;
			}

			public bool MoveNext() => ++_index < _orders.Length;

			public void Reset() => _index = -1;

			public Order Current => _orders[_index];

			object IEnumerator.Current => Current;

			public void Dispose()
			{
			}
		}


	}



}
