using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Magazine Subscription Label Generator!");

        // Input full name
        Console.Write("Enter your full name (first name first): ");
        string fullName = Console.ReadLine();

        // Input birthdate
        Console.Write("Enter your birthdate (mm/dd/yyyy): ");
        DateTime birthdate = DateTime.Parse(Console.ReadLine());

        // Input month of subscription purchase
        Console.Write("Enter the month number you purchased your subscription: ");
        int subscriptionMonth = int.Parse(Console.ReadLine());

        // Input zip code
        Console.Write("Enter your zip code: ");
        string zipCode = Console.ReadLine();

        // Generate mailing label
        string[] nameParts = fullName.Split(' ');
        string lastName = nameParts[nameParts.Length - 1];
        string yearOfBirth = birthdate.Year.ToString().Substring(2);
        int nameLength = fullName.Replace(" ", "").Length;
        string monthAbbreviation = new DateTime(2000, subscriptionMonth, 1).ToString("MMM");
        string zipLastTwoDigits = zipCode.Substring(zipCode.Length - 2);

        string mailingLabel = $"{lastName}{yearOfBirth}{nameLength}{monthAbbreviation}{zipLastTwoDigits}";

        Console.WriteLine("Your mailing label is: " + mailingLabel);
    }
}
