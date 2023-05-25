using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Practical_8
{
    public class Products
    {
        //Encapsulation
        private int _id;
        private string? _name;
        private int _price;
        private string? _description;
        public int Id 
        { 
            get
            {
                return _id;
            } set
            {
                _id = value;
            } 
        }
        public string? ProductName 
        { 
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            } 
        }
        public int Price 
        { 
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }
        public string? Description 
        { 
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            } 
        }
        public static List<Products>? Pdt { get; set; } = new List<Products>();

    }
    // Interface
    interface IAdminActions
    {
        void AddProduct();
        void ViewProduct();
        void DeleteProduct();
        void UpdateProduct();
    }
    // Inheritance
    public class ActionProduct : IAdminActions
    {
        Products pd = new Products();
        public void AddProduct()
        {
            Console.Write("\nEnter Product Id: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Product Name: ");
            string? name = Console.ReadLine();

            Console.Write("Enter Product Price: ");
            int price = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Product Desciption: ");
            string? desc = Console.ReadLine();

            Products.Pdt?.Add(new Products { Id = id, ProductName = name, Price = price, Description = desc });

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nProduct Added successfully");
            Console.ForegroundColor = ConsoleColor.White;

        }

        public void ViewProduct()
        {
            List<Products>? pd1 = Products.Pdt;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\t\t-------View All Products-------");

            foreach (Products Pd1 in pd1)
            {
                Console.WriteLine($"\n{Pd1.Id}) Product name is: '{Pd1.ProductName}' & Price of product: '{Pd1.Price}', & Description of product is: {Pd1.Description}");
            }
            Console.ForegroundColor = ConsoleColor.White;

        }

        public void DeleteProduct()
        {
            Console.Write("\nEnter Id you want to delete: ");
            int idx = Convert.ToInt32(Console.ReadLine());
            Products? p = Products.Pdt?.Find(pd => pd.Id == idx);
             
            Products.Pdt?.Remove(p);
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Deleted Successully " + p.ProductName);
            Console.ForegroundColor = ConsoleColor.White;

        }

        public void UpdateProduct()
        {
            Console.Write("\nEnter Id you want to Update: ");
            int UpdateId = Convert.ToInt32(Console.ReadLine());
            Products? p = Products.Pdt?.Find(pd => pd.Id == UpdateId);

            Console.Write("Enter Product name you want to Update (If you don't want to update hit enter): ");
            string? uName = Console.ReadLine();
            if (uName != string.Empty)
                pd.ProductName = uName;

            Console.Write("Enter product price you want to Update (If you don't want to update hit enter): ");
            int uPrice = Convert.ToInt32(Console.ReadLine());
            if (uPrice != null)
                pd.Price = uPrice;

            Console.Write("Enter Producr Description you want to Update (If you don't want to update hit enter): ");
            string? uDesc = Console.ReadLine();
            if (uDesc != string.Empty)
                pd.Description = uDesc;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nUpdated Successfully of name is " + pd.ProductName);
            Console.ForegroundColor = ConsoleColor.White;

        }
    }

    //Enum
    public enum AdminEnum
    {
        Add_Product = 1,
        View_Product = 2,
        Delete_Product = 3,
        Update_Product = 4
    }

    // Sealed class
    public sealed class Admin
    {
        public static void AdminCrud()
        {
            ActionProduct ap = new ActionProduct();
            string? yOrn;

            //Exception Handling
            try
            {
                do
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\t\t-------Admin Module-------");

                    Console.WriteLine("1- Add Product");
                    Console.WriteLine("2- View Product");
                    Console.WriteLine("3- Delete Product");
                    Console.WriteLine("4- Update Product");

                    Console.ForegroundColor = ConsoleColor.White;

                    Console.Write("\nEnter your choice: ");
                    int ch = Convert.ToInt32(Console.ReadLine());

                    AdminEnum oprt = (AdminEnum)ch;

                    switch(oprt)
                    {
                        case AdminEnum.Add_Product:
                            ap.AddProduct();
                            break;

                        case AdminEnum.View_Product:
                            ap.ViewProduct();
                            break;

                        case AdminEnum.Delete_Product:
                            ap.DeleteProduct();
                            break;

                        case AdminEnum.Update_Product:
                            ap.UpdateProduct();
                            break;

                        default:
                            Console.WriteLine("Invalid choice: ");
                            break;
                    }
                    Console.Write("\nDo you want to continue show admin actions [ y|n ]: ");
                    yOrn = Console.ReadLine();
                    Console.Clear();

                } while(yOrn == "y");
            }
            catch(Exception ex) 
            { 
                Console.WriteLine(ex.Message); 
            }
        }
    }
}
