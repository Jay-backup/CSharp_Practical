public class Bird
{
    public void Voice()
    {
        Console.WriteLine("Turr Turr");
    }
}
public class Duck : Bird
{
    public void Voice()
    {
        Console.WriteLine("Quack Quack");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Bird myBird = new Bird();
        Bird myDuck = new Duck();

        myBird.Voice();
        myDuck.Voice();
    }
}