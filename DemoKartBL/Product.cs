using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKartBL
{
    public class Product
    {
       public int ProductId { get; set; }
        public String ProductName { get; set; }
        public int ProductQuantity { get; set; }
        public double ProductPrice { get; set; }       
        public Category CObj = new Category();     
        public Product()
        {
        }
        public Product(int productId, String productName, double price, int quantity,int CategoriesId,String Categories)
        {
            this.ProductId = productId;
            this.ProductName = productName;
            this.ProductQuantity = quantity;
            this.ProductPrice = price;
            CObj.CategoriesId = CategoriesId;
            CObj.CategoryName = Categories;
        }
        
    }
}
