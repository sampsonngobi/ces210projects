using System;
using System.Security.Cryptography.X509Certificates;

//declare the Activity class
public class Activity
{
    //Declare the variables 
    private string _name;
    private string _description;
    private int _duration;

    //this is the acctivity constructor to initialize the private variables 
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
       
    }
    //Get methods to acces the private variables 
    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void DisplayStartingMessage()
    {   
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Thread.Sleep(3000);

       
       
        Console.Write("How long, in seconds, would you like for your session? ");
        string durationInput = Console.ReadLine();

        // This helps to ensure that user provides a time duration in seconds 
        while(durationInput == "")
        {
            if (durationInput == "")
            {
                Console.WriteLine("Please enter a valid number of seconds");

                Console.Write("How long, in seconds, would you like for your session? ");
                durationInput = Console.ReadLine();
            }

            else
            {
                _duration = int.Parse(durationInput);
            
            }

        Console.WriteLine("Get ready to start in 5 seconds..");
        }
       
       
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well don!!");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
    }

    public void ShowSpinner(int seconds)
    {
        List<string> animationString = new List<string>();
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");

        foreach(string s in animationString)
        {
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void ShowCountDown(int seconds)
    {
           for (int i =  5; i > 0; i--)
            {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            }
    }

}