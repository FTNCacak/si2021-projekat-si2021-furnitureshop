using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Item
    {
        public Item() { }
        public Item(string productName, decimal productPrice, string productColor, string productDescription, string productType, string productCategory, int productStock, int productDiscount)
        {
            ProductName = productName;
            ProductPrice = productPrice;
            ProductColor = productColor;
            ProductDescription = productDescription;
            Type = productType;
            Category = productCategory;
            Stock = productStock;
            Discount = productDiscount;
        }

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
