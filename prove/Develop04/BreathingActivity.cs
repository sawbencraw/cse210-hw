// Breathing Activity
public class BreathingActivity : Activity
{
    public BreathingActivity(string activityName, string description, int duration) : base(activityName, description, duration)
    {
    }

    public override void StartActivity()
    {
        base.StartActivity();
    }

    public void PerformBreathingActivity()
    {
        StartActivity();

        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");

        for (int i = 0; i < _duration; i++)
        {
            Console.WriteLine("Breathe in...");
            Thread.Sleep(2000); // Pause for 2 second
            Console.WriteLine("Breathe out...");
            Thread.Sleep(2000); // Pause for 2 second
        }

        EndActivity();
    }
}