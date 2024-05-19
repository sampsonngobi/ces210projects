using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    //initiate two list one for the prompts and the other for the questions.
    List<string> _prompts = new List<string>();
    List<string> _responses = new List<string>();

    public ListingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        
    }

    public void Run()
    {
        DisplayStartingMessage();

        ShowCountDown(5);

            Console.WriteLine("");
            DisplayPrompt();
            Thread.Sleep(5000);

            Console.WriteLine("");
            Console.WriteLine("Write as many responses as possible in 5 seconds");
            ShowCountDown(5);

            for(int i = 0; i < GetDuration(); i+= 5)
            {

                string response = Console.ReadLine();
                _responses.Add(response);

                //clear the line and write the next response on the sameline
                Console.SetCursorPosition(0, Console.CursorTop - 1); // Move cursor up one line
                Console.Write(new string(' ', Console.WindowWidth)); // Clear the line
                Console.SetCursorPosition(0, Console.CursorTop); // Move cursor back to the beginning of the line

            }
            
            Console.WriteLine("");
            Console.WriteLine("---------------------");
            Console.WriteLine("Your responses");
            Displayresponses();
            Console.WriteLine("");
            
            DisplayEndingMessage();
            Console.WriteLine("");
            Thread.Sleep(10000);

            Console.Clear();
    }

    public string GetRandomPrompt()
    {
        //add prompts to the list 
         _prompts.Add("Who are people that you appreciate?");
         _prompts.Add("What are personal strengths of yours?");
         _prompts.Add("Who are people that you have helped this week?");
         _prompts.Add("When have you felt the Holy Ghost this month?");
         _prompts.Add("Who are some of your personal heroes?");
     
        
         //get a random prompt
         Random prompt = new Random();
         int randomIndex = prompt.Next(_prompts.Count);

         string randomPrompt = _prompts[randomIndex];

         return randomPrompt;

    }

    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }

     public void Displayresponses()
    {
        foreach(string response in _responses)
        {
            Console.WriteLine(response);
        }
        
    }
    
}

