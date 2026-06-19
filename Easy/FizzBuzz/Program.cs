namespace FterDev.Easy.FizzBuzz;

public static class Program
{
    
    public static Task Main(string[] args)
    {


        int num = 100;
        Dictionary<int, string> rules = new Dictionary<int, string>
        {
            {3, "Fizz"},
            {5, "Buzz"}
        };

        var list = FizzBuzzGeneral(num, rules);
        
        PrintFizzBuzz(list);

        return Task.CompletedTask;
    }

    public static List<string> FizzBuzz(int n)
    {

        var list = new List<string>();

        for(int i = 1; i <= n; i++)
        {
            var word = "";

            if(i % 3 == 0)
                word += "Fizz";
            if(i % 5 == 0)
                word += "Buzz";
            
            if(string.IsNullOrEmpty(word))
            {
                list.Add(i.ToString());
            }
            else
            {
                 list.Add(word);
            }   
        }

        return list;
    }

    public static List<string> FizzBuzzGeneral(int n, Dictionary<int, string> rules)
    {
        RuleCheck(rules);
        var list = new List<string>();

        for(int i = 1; i <= n; i++)
        {
            var word = "";
            bool ruleTriggered = false;

            foreach((int r, string w) in rules)
            {
                if(i % r == 0)
                {
                    word += w;
                    ruleTriggered = true;
                }
            }

            list.Add(ruleTriggered ? word : i.ToString());
        }

        return list;
    }

    private static void PrintFizzBuzz(List<string> list)
    {
        foreach(string e in list)
            Console.WriteLine(e);
    }

    private static void RuleCheck(Dictionary<int,string> rules)
    {
        foreach((int i, string w) in rules)
        {
            if(i == 0)
                throw new ArgumentException("You can't use 0 as a rule");
            if(string.IsNullOrEmpty(w))
                throw new ArgumentException("Rule text can't be empty");
        }
    }
}

