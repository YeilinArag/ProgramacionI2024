using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


    public class EmailExtractor
{
    public static List<string> ExtractEmails(string text)
    {
        List<string> emails = new List<string>();
        string pattern = @"\b[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}\b";
        MatchCollection matches = Regex.Matches(text, pattern);

        foreach (Match match in matches)
        {
            emails.Add(match.Value);
        }
        return emails;
    }

    public static void Main(string[] args)
    {
        string text = "Este es mi correo electrónico: juan_perez.23@gmail.com. Por favor, envíeme un correo con sus comentarios. ";
        List<string> emails = ExtractEmails(text);

        foreach (string email in emails)
        {
            Console.WriteLine(email);
        }
    }
}

    
    
       