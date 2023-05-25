using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Practical_8
{
    // Abstraction
    public abstract class CustomerOrder
    {
        public abstract void AddCart();
        public abstract void RemoveCart();
        public abstract void ViewOrder();
    }
    class AddToCart
    {
        public List<Products> CartProduct { get; set; } = new();
    }
    public class OrderList
    {
        public List<Products> Orders { get; set; } = new();

    }
    //Enum
    enum Choice
    {
        AddToCart = 1,
        RemoveFromCart = 2,
        PlaceOrder = 3,
        ViewOrder = 4
    }
    //inheritance
    public class CustomerOperator : CustomerOrder
    {
        Products p = new Products();
        AddToCart addToCart = new();
        OrderList orderList = new();
        string? yOrn;

        //Method Overriding
        public override void AddCart()
        {
            do
            {
                if(Products.Pdt.Count != 0)
                {
                    Console.Write("\nEnter Id you want to Add in cart: ");
                    int idx = Convert.ToInt32(Console.ReadLine());

                    Products? P = Products.Pdt?.Find(p => p.Id == idx);

                    addToCart.CartProduct.Add(P);

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nSuccessfully Add in cart "+p.ProductName);
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.Write("\nDo you want to Add another item in Cart [ y|n ]: ");
                    yOrn = Console.ReadLine();

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nProduct is Empty");
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.ReadLine();
                    break;
                }
            }
            while (yOrn == "y");
        }

        public override void RemoveCart()
        {
            if(addToCart.CartProduct.Count != 0)
            {
                Console.Write("\nEnter Id you want to delete in Cart: ");
                int idx = Convert.ToInt32(Console.ReadLine());
                Products? P = addToCart.CartProduct?.Find(addToCart => addToCart.Id == idx);

                addToCart.CartProduct?.Remove(P);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nDeleted Successully " + p.ProductName);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nCart is Empty");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadLine();
            }
        }

        //Method Overloading
        public void GenerateBill(int Price, double tax)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nYour price total is: "+Price);
            Console.WriteLine("Tax is: "+tax+"%");

            Console.WriteLine("\nSub Total of price is: "+(Price*tax));
            Console.ForegroundColor = ConsoleColor.White;

        }
        public void GenerateBill(int Price)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nYour total price is: " + Price);
            Console.WriteLine("Tax is: 0%");

            Console.WriteLine("\nSub Total of price is: "+Price);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void PlaceOrder()
        {
            if(addToCart.CartProduct.Count != 0)
            {
                var total = addToCart.CartProduct.Sum(e => e.Price);
                if(total > 1000)
                {
                    GenerateBill(total, 1.5);
                    orderList.Orders = addToCart.CartProduct.ToList();
                    addToCart.CartProduct.Clear();
                }
                else
                {
                    GenerateBill(total);
                    orderList.Orders = addToCart.CartProduct.ToList();
                    addToCart.CartProduct.Clear();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nPlease add any products in cart");
                Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        public override void ViewOrder()
        {

            List<Products>? pd1 = orderList.Orders;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t\t\t\t----View All Products----");

            foreach (Products Pd1 in pd1)
            {
                Console.WriteLine($"\n{Pd1.Id}) Product name is: '{Pd1.ProductName}' & Price of product: '{Pd1.Price}', & Description of product is: {Pd1.Description}");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    public class Customer
    {
        CustomerOperator Cart = new();
        string? yOrn;

        public void CustomerDetailes()
        {
            try
            {
                string? userName, Password;
                do
                {
                    Console.WriteLine("\t\t-------Customer Module-------\n");

                    Console.Write("Enter Username: ");
                    userName = Console.ReadLine();
                    Console.Write("Enter Password: ");
                    Password = Console.ReadLine();

                    if (userName == "jay" && Password == "Jay@123")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nLogin Successfully of " + userName);
                        Console.ForegroundColor = ConsoleColor.White;
                        do
                        {
                            Console.ReadLine();
                            Console.Clear();

                            List<Products>? pd1 = Products.Pdt;

                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("\t\t\t\t----View All Products----");

                            foreach (Products Pd1 in pd1)
                            {
                                Console.WriteLine($"\n{Pd1.Id}) Product name is: '{Pd1.ProductName}' & Price of product: '{Pd1.Price}', & Description of product is: {Pd1.Description}");
                            }
                            Console.ForegroundColor = ConsoleColor.White;

                            Console.WriteLine("\n1- Add to cart");
                            Console.WriteLine("2- Remove from cart");
                            Console.WriteLine("3- Place order");
                            Console.WriteLine("4- View order");
                            Console.WriteLine("--------------------------");

                            Console.Write("\nEnter your choice: ");
                            int ch = Convert.ToInt32(Console.ReadLine());

                            switch ((Choice)ch)
                            {
                                case Choice.AddToCart:
                                     Cart.AddCart();
                                    break;

                                case Choice.RemoveFromCart:
                                    Cart.RemoveCart();
                                    break;

                                case Choice.PlaceOrder:
                                    Console.Write("\nDo you want to Place your order [ y|n ]: ");
                                
                                    if (Console.ReadLine() == "y")
                                        Cart.PlaceOrder();
                                    else
                                        Console.WriteLine("Thank you!!");
                                    break;

                                case Choice.ViewOrder:
                                    Cart.ViewOrder();
                                    break;

                                default:
                                    Console.WriteLine("\nWrong choice choose");
                                    break;
                            }
                            Console.Write("\nDo you want to continue customer option [ y|n ]: ");
                            yOrn = Console.ReadLine();
                            Console.Clear();
                        } while (yOrn == "y");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nYou enter wrong username and password\n");
                        Console.ForegroundColor = ConsoleColor.White;

                    }
                } while (userName != "jay" || Password != "Jay@123");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }


}
