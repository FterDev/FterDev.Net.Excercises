namespace FterDev.Easy.StringReverser;

public class StringReverser
{

    public string ReverseString(string input)
    {
        if(string.IsNullOrEmpty(input))
            throw new ArgumentNullException("Empty strings are not allowed");

        if(input.Length == 1)
            throw new ArgumentException("One char strings not allowed");
        
        var list = input.Split(" ").ToList<string>();

        for(int i = 0; i < list.Count; i++)
        {
            list[i] = Reverse(list[i]);
        }

        var result = string.Join(" ", list);

        return result;
        
    }

    private string Reverse(string input)
    {
        int length = input.Length;

        if(length == 0)
            return input;

        char[] reversed = new char[length];

        for(int i = 0; i < length; i++)
        {
            reversed[length - 1 - i] = input[i];
        }

        return new string(reversed);
    }

}
