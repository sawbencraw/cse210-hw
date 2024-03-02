// Listing Activity
public class ListingActivity : Activity
{
    private string[] _prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(string activityName, string description, int duration) : base(activityName, description, duration)
    {
    }

    public override void StartActivity()
    {
        base.StartActivity();
    }

    public void PerformListingActivity()
    {
        StartActivity();

        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Length)];

        Console.WriteLine(prompt);
        Console.WriteLine($"You have {_duration} seconds to list items...");

        Thread.Sleep(_duration * 1000); // Pause for the specified duration

        Console.WriteLine($"You listed {_duration} items.");

        EndActivity();
    }
}