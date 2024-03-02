// Reflection Activity
public class ReflectionActivity : Activity
{
    private string _chosenPrompt; // Store the chosen prompt
    private string[] _prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] _questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity(string activityName, string description, int duration) : base(activityName, description, duration)
    {
        _chosenPrompt = GetRandomPrompt();
    }

    // Method to get a random prompt
    private string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Length)];
    }

    public override void StartActivity()
    {
        base.StartActivity();
    }

    public void PerformReflectionActivity()
    {
        StartActivity();

        Console.WriteLine($"This activity will help you reflect on times in your life when you have shown strength and resilience by choosing the following prompt: {_chosenPrompt}");

        foreach (string question in _questions)
        {
            Console.WriteLine(question);
            Thread.Sleep(2000); // Pause for 2 seconds
            DisplayAnimation();
        }

        EndActivity();

        // Return to the main menu
        ReturnToMainMenu();
    }

    // Method to return to the main menu
    private void ReturnToMainMenu()
    {
        Console.WriteLine("\nPress any key to return to the main menu...");
        Console.ReadKey();
    }
}