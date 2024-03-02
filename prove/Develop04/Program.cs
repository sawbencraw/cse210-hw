using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness App");

        while (true)
        {
            Console.WriteLine("\nChoose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter duration in seconds: ");
                    int breathingDuration = Convert.ToInt32(Console.ReadLine());
                    BreathingActivity breathingActivity = new BreathingActivity("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", breathingDuration);
                    breathingActivity.PerformBreathingActivity();
                    break;
                case 2:
                    Console.Write("Enter duration in seconds: ");
                    int reflectionDuration = Convert.ToInt32(Console.ReadLine());
                    ReflectionActivity reflectionActivity = new ReflectionActivity("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", reflectionDuration);
                    reflectionActivity.PerformReflectionActivity();
                    break;
                case 3:
                    Console.Write("Enter duration in seconds: ");
                    int listingDuration = Convert.ToInt32(Console.ReadLine());
                    ListingActivity listingActivity = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", listingDuration);
                    listingActivity.PerformListingActivity();
                    break;
                case 4:
                    Console.WriteLine("Thank you for using the Mindfulness App. Goodbye!");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
