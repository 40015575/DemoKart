using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKartBl
{
    public class Product
    {
        /*  public String ProdId { get; set; }
          public String ProdName { get; set; }
          public int Price { get; set; }
          public int Quantity { get; set; }
          public Product()
          {

          }
          public Product(String Pid,String Pname,int Pr,int quan)
          {
              ProdId = Pid;
              ProdName = Pname;
              Price = Pr;
              Quantity = quan;
          }*/
        public int Catid { get; set; }
        public int ProdId { get; set; }
        public String ProdName { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        Category cobj;
        public static Dictionary<int, int> ProductQuantity = new Dictionary<int, int>() { { 101, 3 }, { 102, 4 }, { 103, 10 }, { 104, 12 }, { 105, 3 }, { 106, 4 }, { 107, 10 }, { 108, 12 }, { 109, 3 }, { 110, 4 }, { 111, 10 }, { 112, 12 }, { 113, 3 }, { 114, 4 }, { 115, 10 }, { 116, 12 } };
        public static Dictionary<int, int> ProductPrice = new Dictionary<int, int>() { { 101, 35000 }, { 102, 15000 }, { 103, 350 }, { 104, 500 }, { 105, 1000 }, { 106, 1500 }, { 107, 1600 }, { 108, 2000 }, { 109, 1000 }, { 110, 1500 }, { 111, 300 }, { 112, 500 }, { 113, 350 }, { 114, 1500 }, { 115, 350 }, { 116, 500 } };
        public static Dictionary<int, String> ProductName = new Dictionary<int, String>() { { 101, "Laptop" }, { 102, "Mobile" }, { 103, "Charger" }, { 104, "PenDrive" }, { 105, "Almond" }, { 106, "Cashew" }, { 107, "Pista" }, { 108, "WalNut" }, { 109, "BodySpray" }, { 110, "BodyLotion" }, { 111, "FacePowder" }, { 112, "Conditioner" }, { 113, "Shirts" }, { 114, "Pants" }, { 115, "Kurtas" }, { 116, "Kurtis" } };
        public static Dictionary<int, int> ProductCat = new Dictionary<int, int>() { { 101, 1 }, { 102, 1 }, { 103, 1 }, { 104, 1 }, { 105, 2 }, { 106, 2 }, { 107, 2 }, { 108,2 }, { 109, 3 }, { 110, 3 }, { 111, 3 }, { 112, 3 }, { 113, 4 }, { 114, 4 }, { 115, 4 }, { 116, 4} };
        public List<Product> Prod = new List<Product>();
        public Product()
        {
            Prod.Add(new Product(1,101, "Laptop    ", 35000, 3));
            Prod.Add(new Product(1,102, "Mobile    ", 15000, 4));
            Prod.Add(new Product(1,103, "Charger   ", 350, 10));
            Prod.Add(new Product(1,104, "Pendrive  ", 500, 12));
            Prod.Add(new Product(2,105, "Almond    ", 1000, 3));
            Prod.Add(new Product(2,106, "Cashew    ", 1500, 4));
            Prod.Add(new Product(2,107, "Pista     ", 1600, 10));
            Prod.Add(new Product(2,108, "WalNut    ", 2000, 12));
            Prod.Add(new Product(3,109, "BodySpray", 1000, 3));
            Prod.Add(new Product(3,110, "BodyLotion", 1500, 4));
            Prod.Add(new Product(3,111, "FacePowder", 300, 10));
            Prod.Add(new Product(3,112, "Conditioner", 500, 12));
            Prod.Add(new Product(4,113, "Shirts   ", 350, 3));
            Prod.Add(new Product(4,114, "Pants     ", 1500, 4));
            Prod.Add(new Product(4,115, "Kurtas    ", 350, 10));
            Prod.Add(new Product(4,116, "Kurtis    ", 500, 12));
        }
        public Product(int catId,int Pid, String Pname, int Pr, int quan)
        {
            cobj.CatId = catId;
            ProdId = Pid;
            ProdName = Pname;
            Price = Pr;
            Quantity = quan;
        }
        public void displayElectronics()
        {
            for(int i=0;i<4;i++)
            {
                Console.WriteLine("Products Available in the website\n");
                Console.WriteLine("ProductId          ProductName            Price        Quantity");
                for (int i = 0; i < 4; i++)
                    Console.WriteLine(Prod[i].Pid + " " + Product[i.ProdName + " " + item.Price + " " + item.Quantity + " ");
            }
        }
    }
}
 