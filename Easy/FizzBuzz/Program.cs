namespace FterDev.Easy.FizzBuzz;

public static class Program
{
    
    public static Task Main(string[] args)
    {
        int num = 0;

        Console.Write("Add an int for FizzBuzz:");
        num = Console.Read();

        return Task.CompletedTask;
    }

    public static void FizzBuzz(int n)
    {
        
    }
}

