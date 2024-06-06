using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running running1 = new Running(120,"20th Mar. 2024",60);
        activities.Add(running1);

        Cycling cycling1 = new Cycling(100, "6th Jan. 2024", 90);
        activities.Add(cycling1);

        Swimming swimming1 = new Swimming(200, "6th Jun. 2024", 60);
        activities.Add(swimming1);

        Console.WriteLine();
        foreach(var activity in activities)
        {
            
            Console.WriteLine($"{activity.GetSummary()}");
        }
        Console.WriteLine();
    }
}