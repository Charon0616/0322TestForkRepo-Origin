using System;
using System.Text.RegularExpressions;

public class Example
{
    public static void Main()
    {
        string input = "1851 1999 1950 1905 2003";
        //Extenal
        string pattern = @"(?<=19)\d{2}\b";

        foreach (Match match in Regex.Matches(input, pattern))
            Console.WriteLine(match.Value);
        //add new line
        //namesdgasfadf
    }
}