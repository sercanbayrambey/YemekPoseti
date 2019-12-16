using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YemekPoşeti
{
	public class Order
	{
		public float SumPrice { get; set; }
		public List<ucBasket> FoodsInOrder = new List<ucBasket>();

		public float GetSumPrice()
		{
			SumPrice = 0;
			foreach(ucBasket ucbasket in FoodsInOrder )
			{
				SumPrice += (ucbasket.QTY * ucbasket.Price);
			}
			return SumPrice;
		}

	}
}
