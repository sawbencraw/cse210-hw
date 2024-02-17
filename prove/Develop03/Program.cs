using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the scripture reference:");
        string reference = Console.ReadLine();

        Console.WriteLine("Enter the scripture text:");
        string text = Console.ReadLine();

        var scripture = new Scripture(new Reference(reference), text);
        scripture.Display();

        while (!scripture.AllWordsHidden)
        {
            Console.WriteLine("Press Enter to continue or type 'quit' to exit:");
            string input = Console.ReadLine().ToLower();

            if (input == "quit")
                break;

            scripture.HideRandomWord();
            scripture.Display();
        }

        Console.WriteLine("Program ended.");
    }
}