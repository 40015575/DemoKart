using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKartBl
{
   public class Cart:Product
    {
        int Price;
        int q;
        //Order or;
        List<int> cart = new List<int>();
        public int ProductIdExits(int Pid)
        {
            if(ProductName.ContainsKey(Pid))
            {
             //   Price = ProductPrice[Pid];
               // q = ProductQuantity[Pid];
                return 1;
            }
            return 0;
        }
        public void AddCartDetails(int Pid,int quantity)
        {
            // Console.WriteLine(ProductName[Pid]+"\t"+ProductPrice[Pid]+"\t"+quantity);
            cart.Add(Pid);
            cart.Add(quantity);
            cart.Add(ProductPrice[Pid]);

 
        }
    }
}

