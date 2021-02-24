using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKartBL
{
    public class Cart : Product
    {
        //Delete this method before submission
        //Method was created to generate test project
        public String productId { get; set; }
        public int quantity { get; set; }
        public Cart(String pid, int q)
        {
            productId = pid;
            quantity = q;
        }
        public bool verifyProdid(String pid)
        {
            if (product.ContainsKey(productId))
                return true;
            return false;
        }
        public int cartdetails()
        {
            int p = 0;
            bool keyExists = product.ContainsKey(productId);
            if (keyExists)
            {
                quantityPid[productId] -= quantity;
                p += product[productId];
                return p;
            }
            else
                return 0;
        }
    }
}
