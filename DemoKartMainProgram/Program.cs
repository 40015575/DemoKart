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
        static List<Product> CartsList = new List<Product>(20);

        static List<Product> ProductsList = new List<Product>(20);
        public void Display(int id)
        {
            foreach(Product items in ProductsList)
            {
                if(id==items.CObj.CategoriesId)
                {
                    Console.WriteLine("Product id : " + items.ProductId + "\tProduct Name : " + items.ProductName + "\tProduct Price : " + items.ProductPrice + "\tProduct Quantity : " + items.ProductQuantity + "\tCategory Id : " + items.CObj.CategoriesId + "\tCategory Name : " + items.CObj.CategoryName);
                }
            }
        }


        static void Main(string[] args)
        {
            try
            {
                Product[] ProObj = new Product[20];
                for (int i = 0; i < 13; i++)
                {
                    ProObj[0] = new Product(1, "Mobile", 10000, 5, 1, "Electronics");
                    ProObj[1] = new Product(2, "Laptop", 35000, 2, 1, "Electronics");
                    ProObj[2] = new Product(3, "TV", 500, 10, 1, "Electronics");
                    ProObj[3] = new Product(4, "Watch", 100, 4, 3, "Clothing");
                    ProObj[4] = new Product(5, "Fan", 500, 4, 1, "Electronics");
                    ProObj[5] = new Product(6, "Saree", 500, 4, 3, "Clothing");
                    ProObj[6] = new Product(7, "Shirt", 500, 4, 3, "Clothing");
                    ProObj[7] = new Product(8, "Pant", 500, 4, 3, "Clothing");
                    ProObj[8] = new Product(9, "Skirt", 500, 4, 3, "Clothing");
                    ProObj[9] = new Product(10, "Eggs", 50, 4, 2, "Grocery");
                    ProObj[10] = new Product(11, "Milk", 90, 4, 2, "Grocery");
                    ProObj[11] = new Product(12, "Lipstick", 5000, 4, 4, "Cosmetics");
                    ProObj[12] = new Product(13, "eyeliner", 5000, 4, 4, "Cosmetics");

                    ProductsList.Add(ProObj[i]);

                }

                Category CatObj = new Category();
                Cart CartObj = new Cart();
                Program ProgObj = new Program();

                Order OrderObj = new Order();
                Payment paymentObj = new Payment();
                int res1, res2, res5, id;
                double TotalPrice = 0, TotalPrice1 = 0, TotalPrice2 = 0, TotalPrice3 = 0, TotalPrice4 = 0;
                double GrandTotal1 = 0, GrandTotal2 = 0;
                User UserObj = new User();
                Console.WriteLine("Welcome to Online Shopping");
                Console.WriteLine("Enter The User Name");
                String UserName = Console.ReadLine();
                Console.WriteLine("Enter The Password");
                String Password = Console.ReadLine();
                int value = UserObj.Getauthorized(UserName, Password);

                if (value == 1)
                {
                    do
                    {
                        Console.WriteLine("1.Electronics\t2.Grocery\t3.Clothing\t4.Cosmetics");
                        int n = Convert.ToInt32(Console.ReadLine());
                        switch (n)
                        {
                            default:
                                Console.WriteLine("Have made wrong choice!");
                                break;
                            case 1:
                                ProgObj.Display(n);
                                Console.WriteLine("1.Add To Cart\t2.Continue");
                                res2 = Convert.ToInt32(Console.ReadLine());
                                if (res2 == 1)
                                {
                                    Console.WriteLine("\nEnter the product ID of the product  you want to add  : ");
                                    id = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("\nEnter The Quantity You Want");
                                    int quant = Convert.ToInt32(Console.ReadLine());
                                    foreach (Product item in ProductsList)
                                    {
                                        if (id == item.ProductId)
                                        {
                                            value = CartObj.AddToCart(quant);
                                            if (value == 1)
                                            {
                                                Console.WriteLine("Quantity Size Exceeded The Limit\n");
                                            }
                                            else
                                            {
                                                double TotalPric = CatObj.PriceCalc(n, item.ProductPrice, quant);
                                                TotalPrice1 = TotalPrice1 + TotalPric;
                                                Product cust_cart = new Product(item.ProductId, item.ProductName, item.ProductPrice, quant, item.CObj.CategoriesId, item.CObj.CategoryName);
                                                CartsList.Add(cust_cart);
                                                Console.WriteLine("Add To cart Is Successfull\n");
                                            }

                                        }
                                    }

                                }
                                break;
                            case 2:
                                ProgObj.Display(n);
                                Console.WriteLine("1.Add To Cart\t2.Continue");
                                res2 = Convert.ToInt32(Console.ReadLine());
                                if (res2 == 1)
                                {
                                    Console.WriteLine("\nEnter the product ID of the product you want to Add to Cart : ");
                                    id = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("\nEnter the Quantity you want");
                                    int quant = Convert.ToInt32(Console.ReadLine());
                                    foreach (Product item in ProductsList)
                                    {
                                        if (id == item.ProductId)
                                        {
                                            value = CartObj.AddToCart(quant);
                                            if (value == 1)
                                                Console.WriteLine("You have exceeded the limit than what we have!\n");
                                            else
                                            {
                                                double TotalP = CatObj.PriceCalc(n, item.ProductPrice, quant);
                                                TotalPrice1 = TotalPrice1 + TotalP;
                                                Product cust_cart = new Product(item.ProductId, item.ProductName, item.ProductPrice, quant, item.CObj.CategoriesId, item.CObj.CategoryName);
                                                CartsList.Add(cust_cart);
                                                Console.WriteLine("Successfully added to cart!\n");
                                            }

                                        }
                                    }

                                }
                                break;
                            case 3:
                                ProgObj.Display(n);
                                Console.WriteLine("1.Add To Cart\t2.Continue");
                                res2 = Convert.ToInt32(Console.ReadLine());
                                if (res2 == 1)
                                {
                                    Console.WriteLine("\nEnter ID's of Product You Want Add to Cart : ");
                                    id = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("\nEnter How Many Quantity You Want");
                                    int quant = Convert.ToInt32(Console.ReadLine());
                                    foreach (Product item in ProductsList)
                                    {
                                        if (id == item.ProductId)
                                        {
                                            value = CartObj.AddToCart(quant);
                                            if (value == 1)
                                            {
                                                Console.WriteLine("Quantity Size Exceed The Limit\n");
                                                break;
                                            }
                                            else
                                            {
                                                double TotalPric = CatObj.PriceCalc(n, item.ProductPrice, quant);
                                                TotalPrice1 = TotalPrice1 + TotalPric;
                                                Product cust_cart = new Product(item.ProductId, item.ProductName, item.ProductPrice, quant, item.CObj.CategoriesId, item.CObj.CategoryName);
                                                CartsList.Add(cust_cart);
                                                Console.WriteLine("Successfully added to cart!\n");
                                            }

                                        }
                                    }

                                }
                                break;
                            case 4:
                                ProgObj.Display(n);
                                Console.WriteLine("1.Add To Cart\t2.Continue");
                                res2 = Convert.ToInt32(Console.ReadLine());
                                if (res2 == 1)
                                {
                                    Console.WriteLine("\nEnter ID's of Product You Want Add to Cart : ");
                                    id = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("\nEnter How Many Quantity You Want");
                                    int quant = Convert.ToInt32(Console.ReadLine());
                                    foreach (Product item in ProductsList)
                                    {
                                        if (id == item.ProductId)
                                        {
                                            value = CartObj.AddToCart(quant);
                                            if (value == 1)
                                            {
                                                Console.WriteLine("Quantity Size Exceed The Limit\n");
                                                break;
                                            }
                                            else
                                            {
                                                double TotalPric = CatObj.PriceCalc(n, item.ProductPrice, quant);
                                                TotalPrice1 = TotalPrice1 + TotalPric;
                                                Product cust_cart = new Product(item.ProductId, item.ProductName, item.ProductPrice, quant, item.CObj.CategoriesId, item.CObj.CategoryName);
                                                CartsList.Add(cust_cart);
                                                Console.WriteLine("Add To cart Is Successfull\n");
                                            }

                                        }
                                    }

                                }
                                break;
                        }
                        Console.WriteLine("1.Revisit\t2.Display Cart And Payment");
                        res1 = Convert.ToInt32(Console.ReadLine());
                    } while (res1 == 1);
                    foreach (Product item in CartsList)
                    {

                        Console.WriteLine("Product id : " + item.ProductId);
                        Console.WriteLine("Product Name : " + item.ProductName);
                        Console.WriteLine("Product Price : " + item.ProductPrice);
                        Console.WriteLine("Product Quantity : " + item.ProductQuantity);
                        Console.WriteLine("Product Quantity : " + item.CObj.CategoriesId);
                        Console.WriteLine("Product Quantity : " + item.CObj.CategoryName);
                        Console.WriteLine("\n");
                    }
                    Console.WriteLine("Enter the Details To Complete Order");
                    Console.WriteLine("Enter The First Name : ");
                    OrderObj.FirstName = Console.ReadLine();
                    Console.WriteLine("Enter  The Last Name : ");
                    OrderObj.LastName = Console.ReadLine();
                    Console.WriteLine("Enter The Delivery Address : ");
                    OrderObj.Address = Console.ReadLine();
                    Console.WriteLine("Enter Pincode : ");
                    OrderObj.PinCode = Convert.ToInt32(Console.ReadLine());

                    TotalPrice = TotalPrice1 + TotalPrice2 + TotalPrice3 + TotalPrice4;

                    Console.WriteLine("Choose The Payment Method");
                    Console.WriteLine("1.ByCash\t2.ByCard");
                    res5 = Convert.ToInt32(Console.ReadLine());


                    Console.WriteLine("Order  Placed ..................");
                    Console.WriteLine("First Name : " + OrderObj.FirstName + "\nLast Name : " + OrderObj.LastName + "\nDelivery Address : " + OrderObj.Address + "\nPinCode : " + OrderObj.PinCode);
                    switch (res5)
                    {
                        default:
                            Console.WriteLine("Enter the correct choice");
                            break;
                        case 1:
                            GrandTotal1 = paymentObj.CGSTCalculator(res5, TotalPrice);
                            Console.WriteLine("Central GST is : " + GrandTotal1);
                            GrandTotal2 = paymentObj.SGSTCalculator(res5, TotalPrice);
                            Console.WriteLine("State GST is : " + GrandTotal2);
                            break;
                        case 2:
                            double GrandTotal3 = paymentObj.CGSTCalculator(res5, TotalPrice);
                            Console.WriteLine("Central GST is : " + GrandTotal3);
                            double GrandTotal4 = paymentObj.SGSTCalculator(res5, TotalPrice);
                            Console.WriteLine("State GST is : " + GrandTotal4);
                            break;
                    }
                }
                else if (value == 2)
                {
                    Console.WriteLine("User name exits! please enyter correct password");
                }
                else
                {
                    Console.WriteLine("New account has created");
                }
                Console.ReadKey();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Thank You For Visiting.....................................");
            }

        }

    }
}

