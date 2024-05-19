using System;
using System.Collections.Generic;

public class BreathingActivity : Activity
{
        public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
        {
            
        }

        public void Run()
        {
            DisplayStartingMessage();

            ShowCountDown(5);

            for(int i = 0; i < GetDuration(); i+= 5)
            {
                Console.WriteLine("\nBreath in....");
                ShowSpinner(5);

                Console.WriteLine("\nBreath Out....");
                ShowSpinner(5);
            }
            Console.WriteLine("");
            DisplayEndingMessage();

            Thread.Sleep(5000);

            Console.Clear();
        }
}

