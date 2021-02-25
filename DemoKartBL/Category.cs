using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKartBL
{
    class Category
    {
         public int CategoriesId { get; set; }
        public String CategoryName { get; set; }

        public double TotalPrice = 0;
        public Category()
        {
  
        }
        public Category(int CategoriesId, String Categories)
        {
            this.CategoryName = Categories;
            this.CategoriesId = CategoriesId;
        }


        public double PriceCalc(int type, double price,int Quantity)
        {
            if (type == 1)
            {
                price = price * Quantity;
                TotalPrice = price + (price * 0.18);
                return TotalPrice;
            }
            else if (type == 2)
            {
                price = price * Quantity;
                TotalPrice = price + ( price * 0.04);
                return TotalPrice;
            }
            else if (type == 3)
            {
                price = price * Quantity;
                TotalPrice = price + (price * 0.07);
                return TotalPrice;
            }
            else if (type == 4)
            {
                price = price * Quantity;
                TotalPrice = price + (price * 0.18);
                return TotalPrice;
            }
            else
            {
                return 0;
            }
        }
    }
}
