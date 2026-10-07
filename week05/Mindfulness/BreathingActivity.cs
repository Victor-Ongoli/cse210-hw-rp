using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        DateTime end = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < end)
        {
            Console.Write("Breathe in...");
            ShowCountdown(4);
            Console.WriteLine();

            Console.Write("Now breathe out...");
            ShowCountdown(4);
            Console.WriteLine();
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }
}