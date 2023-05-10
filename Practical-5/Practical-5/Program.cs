class Proram
{
    static void Main(string[] args)
    {
       
        int[] arr = new int[5];

        for(int i = 0; i < 5; i++)
        {
            Console.Write($"Enter {i+1} number: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        try
        {
            Console.WriteLine("----------------------------");
            for (int i=0;i<7;i++)
            {
                Console.Write(arr[i]+", ");
            }
        }
        catch (IndexOutOfRangeException e) 
        {
            Console.WriteLine("\n"+e.Message);
        }
        finally
        {
            Console.WriteLine("\nThis is finally block");
        }
    }
}