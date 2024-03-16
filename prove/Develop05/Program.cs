using System;
using EternalQuestLibrary;

namespace EternalQuestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var myQuest = new EternalQuestLibrary.EternalQuest();

            while (true)
            {
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Add Goal");
                Console.WriteLine("2. Record Event (Complete Goal)");
                Console.WriteLine("3. Display Goals");
                Console.WriteLine("4. Display Score");
                Console.WriteLine("5. Save Progress");
                Console.WriteLine("6. Load Progress");
                Console.WriteLine("7. Exit");
                Console.Write("Enter your choice: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter goal name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter goal value: ");
                        int value = int.Parse(Console.ReadLine());
                        Console.WriteLine("Select goal type:");
                        Console.WriteLine("1. Simple Goal");
                        Console.WriteLine("2. Eternal Goal");
                        Console.WriteLine("3. Checklist Goal");
                        Console.Write("Enter goal type: ");
                        int goalType = int.Parse(Console.ReadLine());

                        switch (goalType)
                        {
                            case 1:
                                myQuest.AddGoal(new EternalQuestLibrary.SimpleGoal(name, value));
                                break;
                            case 2:
                                myQuest.AddGoal(new EternalQuestLibrary.EternalGoal(name, value));
                                break;
                            case 3:
                                Console.Write("Enter target count: ");
                                int target = int.Parse(Console.ReadLine());
                                myQuest.AddGoal(new EternalQuestLibrary.ChecklistGoal(name, value, target));
                                break;
                            default:
                                Console.WriteLine("Invalid goal type.");
                                break;
                        }
                        break;
                    case 2:
                        Console.Write("Enter goal index to complete: ");
                        int index = int.Parse(Console.ReadLine());
                        string completionMessage = myQuest.RecordEvent(index - 1);
                        if (!string.IsNullOrEmpty(completionMessage))
                            Console.WriteLine(completionMessage);
                        else
                            Console.WriteLine("Invalid goal index.");
                        break;
                    case 3:
                        Console.WriteLine("Goals:");
                        myQuest.DisplayGoals();
                        break;
                    case 4:
                        myQuest.DisplayScore();
                        break;
                    case 5:
                        Console.Write("Enter filename to save progress: ");
                        string saveFilename = Console.ReadLine();
                        myQuest.SaveProgress(saveFilename);
                        Console.WriteLine($"Progress saved to {saveFilename}.");
                        break;
                    case 6:
                        Console.Write("Enter filename to load progress: ");
                        string loadFilename = Console.ReadLine();
                        myQuest = EternalQuestLibrary.EternalQuest.LoadProgress(loadFilename);
                        Console.WriteLine($"Progress loaded from {loadFilename}.");
                        break;
                    case 7:
                        Console.WriteLine("Exiting program...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }
            }
        }
    }
}
