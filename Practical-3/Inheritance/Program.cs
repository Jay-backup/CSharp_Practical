public class Sponsor
{
    protected string owner = "Rakuteen";
}
public class Team : Sponsor
{
    private string teamName;

    public string TeamName { get => teamName; set => teamName = value; }

    public void printInfo()
    {
        Console.WriteLine($"Owner name is: {owner} & That's our team name is: {TeamName}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Team team = new Team();
        team.TeamName = "Titans";
        team.printInfo();
    }
}
