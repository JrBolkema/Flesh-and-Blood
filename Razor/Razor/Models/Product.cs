using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Razor.Models
{
	public class Product
	{
		public int ProductID { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public decimal Price { get; set; }
		public string Category { get; set; }
		public int? StockLevel { get; set; }


		//public static Product[] GetProducts()
		//{
		//	Product kayak = new Product
		//	{
		//		Name = "Kayak",
		//		Price = 275M
		//	};

		//	Product lifejacket = new Product
		//	{
		//		Name = "Lifejacket",
		//		Price = 48.95M
		//	};

		//	return new Product[] { kayak, lifejacket, null };

		//}

	}



}
