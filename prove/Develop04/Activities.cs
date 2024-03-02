// Base class for all activities
public class Activity
{
    protected string _activityName;
    protected string _description;
    protected int _duration; // Duration of the activity in seconds

    // Constructor
    public Activity(string activityName, string description, int duration)
    {
        _activityName = activityName;
        _description = description;
        _duration = duration;
    }

    // Method to display common starting message
    public virtual void StartActivity()
    {
        Console.WriteLine($"Activity Description: {_description}");
        Console.WriteLine($"Duration: {_duration} seconds");
        Console.WriteLine("Get ready to begin...");
        Thread.Sleep(3000); // Pause for 3 seconds
    }

    // Method to display common ending message
    public virtual void EndActivity()
    {
        Console.WriteLine("Good job!");
        Console.WriteLine($"You have completed the {_activityName} activity for {_duration} seconds.");
        Thread.Sleep(3000); // Pause for 3 seconds
    }

    // Method to display animation
    protected void DisplayAnimation()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.Write("/");
            Thread.Sleep(200);
            Console.Write("\b");
            Console.Write("-");
            Thread.Sleep(200);
            Console.Write("\b");
            Console.Write("\\");
            Thread.Sleep(200);
            Console.Write("\b");
            Console.Write("|");
            Thread.Sleep(200);
            Console.Write("\b");
        }
    }
}