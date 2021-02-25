using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKartBL
{
    public class Payment
    {
        enum Mode { Cash=1,Card}
        public double TotalPrice;
        public double CGSTCalculator(int num, double price)
        {
            if (num == (int)Mode.Cash)
            {
  
                TotalPrice = price;
                return TotalPrice;
            }
            else
            {
                TotalPrice = price + (price * 0.035) ;
                return TotalPrice;
            }   
        }
        public double SGSTCalculator(int num, double price)
        {
            if (num == (int)Mode.Cash)
            {
                TotalPrice = price ;
                return TotalPrice;
            }
            else
            {
                TotalPrice = price + (price * 0.035 );
                return TotalPrice;
            }
        }
    }
}
