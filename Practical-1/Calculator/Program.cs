
class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter first number: ");
            int FNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int SNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nThe sum of the {FNumber} and {SNumber} is {FNumber + SNumber}");
            Console.WriteLine($"\nThe substraction of the {FNumber} and {SNumber} is {FNumber - SNumber}");
            Console.WriteLine($"\nThe multiplication of the {FNumber} and {SNumber} is {FNumber * SNumber}");

            if(SNumber == 0)
            {
                Console.WriteLine($"\nThe division of the {FNumber} and {SNumber} is Infinity");
            }
            else 
            { 
                Console.WriteLine($"\nThe division of the {FNumber} and {SNumber} is {FNumber / SNumber}");
            }
        }
        catch (FormatException FE)
        {
            Console.WriteLine("String is not allowed! Please enter only ineteger value.");
        }
    }
}
