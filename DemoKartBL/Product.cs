using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoKartBL
{
    public class Product
    {
      
        public static Dictionary<String, int> product = new Dictionary<String, int>(){
            {"PID200",150},{"PID300",10 },{"PID60",20 },{"PID10",15 },{"PID13",100}, };
        public static Dictionary<String, int> quantityPid = new Dictionary<String, int>(){
                {"PID200", 10 },{"PID300",2 },{"PID60",1 },{"PID10",0 },{"PID13",5}, };
        public static Dictionary<String, String> Proname = new Dictionary<String, String>(){
                {"PID200", "laptop", },{"PID300", "Cashew"},{"PID60","BodySpray"},{"PID10","Mobile" },{"PID13","Charger"}, };
         public void display()
        {
            Console.WriteLine("list of product id and prices\n 1. product id    2.price");
            foreach (KeyValuePair<String, int> item in product)
            {
                Console.WriteLine(item.Key + "\t" + item.Value);
            }
            Console.WriteLine("list of product id and quantitites\n 1. product id    2.quantity"); ;
            foreach (KeyValuePair<String, int> item in quantityPid)
            {
                Console.WriteLine(item.Key + "\t" + item.Value);
            }
        }
    }
}
