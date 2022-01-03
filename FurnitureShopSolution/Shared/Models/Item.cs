using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Item
    {
		public int ItemID { get; set; }
		public string ProductName { get; set; }
		public decimal ProductPrice { get; set; }
		public string ProductColor { get; set; }
		public string ProductDescription { get; set; }
		public string Type { get; set; }
		public string Category { get; set; }
		public int Stock { get; set; }
		public int Discount { get; set; }
	}
}
