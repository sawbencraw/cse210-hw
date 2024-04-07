using System;

public class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Anytown", "CA", "12345");
        Lecture lecture = new Lecture("Introduction to Python", "Learn the basics of Python programming", "June 1, 2023", "7:00 PM", address1, "Jane Doe", 50);

        Address address2 = new Address("456 Oak Rd", "Someville", "NY", "67890");
        Reception reception = new Reception("Company Anniversary", "Celebrate our company's 10th anniversary", "July 15, 2023", "6:00 PM", address2, "rsvp@company.com");

        Address address3 = new Address("789 Maple Ave", "Otherton", "TX", "24680");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Community Picnic", "Join us for food, games, and fun!", "August 20, 2023", "12:00 PM", address3, "Sunny with a high of 75°F");

        // Output marketing messages
        Console.WriteLine("Lecture:");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine("\n" + lecture.GetFullDetails());
        Console.WriteLine("\n" + lecture.GetShortDescription());

        Console.WriteLine("\nReception:");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine("\n" + reception.GetFullDetails());
        Console.WriteLine("\n" + reception.GetShortDescription());

        Console.WriteLine("\nOutdoor Gathering:");
        Console.WriteLine(outdoorGathering.GetStandardDetails());
        Console.WriteLine("\n" + outdoorGathering.GetFullDetails());
        Console.WriteLine("\n" + outdoorGathering.GetShortDescription());
    }
} 