
using Practical_8;

class Program
{
    enum Online
    {
        Admin = 1,
        Customer = 2,
        Exit = 3
    }
    static void Main(string[] args)
    {
        Customer cs = new Customer();
        string yOrn;
        do
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\t\t-------Order System--------\n");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("1: Admin");
            Console.WriteLine("2: Customer");
            Console.WriteLine("3: Exit");

            Console.WriteLine("---------------------");

            Console.Write("Enter your choice: ");
            int ch = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            switch ((Online)ch)
            {
                case Online.Admin:
                    Admin.AdminCrud();
                    break;

                case Online.Customer:
                    cs.CustomerDetailes();
                    break;

                case Online.Exit:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Wrong Choice");
                    break;
            }
            Console.Write("\nDo you want to continue with other modes [ y|n ]: ");
            yOrn = Console.ReadLine();
        } while (yOrn == "y");
    }
}