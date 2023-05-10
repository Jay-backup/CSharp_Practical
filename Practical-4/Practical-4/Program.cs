using System.Security.Cryptography.X509Certificates;
using System.Collections;
using System.Runtime.Intrinsics.X86;

public class Student 
{
    public string? Name { get; set; }
    public decimal[] Marks = new decimal[5];
    public static decimal AverageMarks { get; set; }


    public decimal CalculateAverageMarks(decimal[] Mark)
    {
        AverageMarks = (Mark[0] + Mark[1] + Mark[2] + Mark[3] + Mark[4])/5;
        return AverageMarks;
    }

    public string CalculateGrade(decimal[] Mark)
    {
        decimal avg = CalculateAverageMarks(Marks);

        return avg switch
        {
            > 90 => "A Grade",
            > 80 => "B Grade",
            > 70 => "C Grade",
            < 70 => "D Grade",
        };
    }

    public int MinMark(decimal[] Mark)
    {
        decimal minNumber = Mark[0];
        for (int i = 0; i < 5; i++)
        {
            if (Mark[i] < minNumber)
            {
                minNumber = Mark[i];
            }
        }
        return (int)minNumber;
    }

    public int MaximumMark(decimal[] Mark)
    {
        decimal maxNumber = Mark[0];
        for (int i = 0; i < 5; i++)
        {
            if (Mark[i] > maxNumber)
            {
                maxNumber = Mark[i];
            }
        }
        return (int)maxNumber;
    }
    
}
public enum Options
{
    Aggregate = 1,

    Minmarks = 2,
    
    MaximumMarks = 3,
    
    Grade = 4
}

class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Student st1 = new Student();

            Console.Write("Enter Your name: ");
            st1.Name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n---Enter student Mark---");
            Console.ForegroundColor = ConsoleColor.White;

            int Mark;
            for (int i = 0; i < 5 ; i++)
            {
                do
                {
                    Console.Write($"Enter Subject {i + 1} marks: ");
                    Mark = Convert.ToInt32(Console.ReadLine());

                    st1.Marks[i] = Convert.ToDecimal(Mark);
                } while ((Mark < 0 || Mark > 100));
                
            }
            int choose;
            do
            {
                Console.WriteLine("\nChoose the number");
                Console.WriteLine("0- Exit");
                Console.WriteLine("1- Aggregate");
                Console.WriteLine("2- MinMark");
                Console.WriteLine("3- MaximumMark");
                Console.WriteLine("4- Grade");

                Console.Write("\nEnter your choice (1 to 4): ");

                choose = Convert.ToInt32(Console.ReadLine());
                Options opt = (Options)choose;

                string result = opt switch
                {
                    Options.Aggregate => $"Average marks is: {st1.CalculateAverageMarks(st1.Marks)}",

                    Options.Minmarks => $"Minimum mark is: {st1.MinMark(st1.Marks)}",

                    Options.MaximumMarks => $"Maximum mark is: {st1.MaximumMark(st1.Marks)}",

                    Options.Grade => $"{st1.CalculateGrade(st1.Marks)}",

                    _ => "Invalid Input",

                };
                Console.WriteLine(result);

            } while (!(choose == 0));

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}