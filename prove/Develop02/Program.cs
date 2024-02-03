using System;
using System.Collections.Generic;
using System.IO;

class Program {
    static void Main(string[] args) {
        string journalFolderPath;

        if (args.Length > 0) {
            journalFolderPath = args[0];
        } else {
            Console.Write("Enter the path to the journal repository: ");
            journalFolderPath = Console.ReadLine();
        }

        // Append "journalRepository" to the specified path
        journalFolderPath = Path.Combine(journalFolderPath, "journalRepository");

        Journal journal = new Journal(journalFolderPath);
        Random random = new Random();

        bool exit = false;
        while (!exit) {
            Console.WriteLine("\n1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");

            Console.Write("Choose an option: ");
            if (int.TryParse(Console.ReadLine(), out int choice)) {
                switch (choice) {
                    case 1:
                        string[] prompts = {
                            "Who was the most interesting person I interacted with today?",
                            "What was the best part of my day?",
                            "How did I see the hand of the Lord in my life today?",
                            "What was the strongest emotion I felt today?",
                            "If I had one thing I could do over today, what would it be?"
                        };
                        string randomPrompt = prompts[random.Next(prompts.Length)];

                        Console.WriteLine($"Prompt: {randomPrompt}");
                        Console.Write("Your response: ");
                        string response = Console.ReadLine();
                        journal.AddEntry(new Entry(randomPrompt, response, DateTime.Now));
                        break;
                    case 2:
                        journal.DisplayEntries();
                        break;
                    case 3:
                        Console.Write("Enter filename to save: ");
                        string saveFileName = Console.ReadLine();
                        journal.SaveToFile(Path.Combine(journalFolderPath, saveFileName));
                        break;
                    case 4:
                        Console.Write("Enter filename to load: ");
                        string loadFileName = Console.ReadLine();
                        journal.LoadFromFile(Path.Combine(journalFolderPath, loadFileName));
                        break;
                    case 5:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please choose again.");
                        break;
                }
            } else {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }
}