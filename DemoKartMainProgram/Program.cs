using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoKartBL;

namespace DemoKartMainProgram
{
    class Program
    {

         static void Main(string[] args)
        {
           
            User uObj = new User();
            Product pObj = new Product();
            pObj.display();
            Console.WriteLine("Enter the UserName:");
            String User = Console.ReadLine();
            Console.WriteLine("Enter the Password:");
            String Pswd = Console.ReadLine();
            int res = uObj.GetAuthorized(User, Pswd);
            if (res == 1)
            {
                Console.WriteLine("What you want to do");
                Console.WriteLine("1.display all the products  2.add product to the cart");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    default:
                        Console.WriteLine("Entered wrong choice.Plese visit again!");
                        break;
                    case 1:
                        pObj.display();
                        break;
                    case 2:
                        pObj.display();
                        Console.WriteLine("Enter product id:");
                        String productId = Console.ReadLine();
                        Console.WriteLine("Enter product quantity:");
                        int quantity = Convert.ToInt32(Console.ReadLine());
                        if (quantity <= 2)
                        {
                            Cart c = new Cart(productId, quantity);
                            if (c.verifyProdid(productId))
                            {
                                int price = c.cartdetails();
                                Console.WriteLine("total price is"+price);
                            }
                            else
                                Console.WriteLine("No such pid exist");
                        }
                        else
                            Console.WriteLine("Enter less than 2 quantities");
                        break;
                }

            }
            else if (res == 0)
            {
                Console.WriteLine("UserName exist! Please enter correct password.");
            }
            else
            {
                Console.WriteLine("UserName does not exist!Please try again!");
            }
        }
    }
}
