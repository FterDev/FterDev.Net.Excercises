namespace FterDev.Easy.StringReverser;

public class StringReverser
{

    public string ReverseString(string input)
    {
        if(string.IsNullOrEmpty(input))
            throw new ArgumentNullException("Empty strings are not allowed");

        if(input.Length == 1)
            throw new ArgumentException("One char strings not allowed");
        
        throw new NotImplementedException();
    }

}
