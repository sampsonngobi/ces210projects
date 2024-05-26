using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    // Private fields
    private List<Goal> _goals;
    private int _score;

    // Constructor to initialize the GoalManager
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    // Main function to start the menu loop
    public void Start()
    {
        string userResponse = "";
        while (userResponse != "6")
        {
            Console.WriteLine($"\nYou have {_score} points");
            Console.WriteLine("\nMenu Options");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            Console.Write("Select a choice from the menu: ");
            userResponse = Console.ReadLine();

            if (userResponse == "1")
            {
                CreateGoal();
            }
            else if (userResponse == "2")
            {
                ListGoalDetails();
            }
            else if (userResponse == "3")
            {
                SaveGoals();
            }
            else if (userResponse == "4")
            {
                LoadGoals();
            }
            else if (userResponse == "5")
            {
                RecordEvent();
            }
            else if (userResponse == "6")
            {
                Console.WriteLine("\nThank you for using our app! Goodbye!");
            }
            else
            {
                Console.WriteLine("\nInvalid option entered. Please try again.");
            }
        }
    }

    private void CreateGoal()
    {
        Console.WriteLine("Select Goal Type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Enter choice: ");
        string choice = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter points for the goal: ");
        int points = int.Parse(Console.ReadLine());

        if (choice == "1")
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (choice == "2")
        {
            _goals.Add(new EnternalGoal(name, description, points));
        }
        else if (choice == "3")
        {
            Console.Write("Enter target number of completions: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("Enter bonus points for reaching the target: ");
            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }
        else
        {
            Console.WriteLine("Invalid goal type. Goal creation aborted.");
        }
    }

    private void ListGoalDetails()
    {
        Console.WriteLine("Goal Details:");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    private void RecordEvent()
    {
        Console.Write("Enter the number of the goal you have completed: ");
        int goalNumber = int.Parse(Console.ReadLine()) - 1;

        if (goalNumber >= 0 && goalNumber < _goals.Count)
        {
            _score += _goals[goalNumber].Points;
            _goals[goalNumber].RecordEvent();
            if (_goals[goalNumber] is ChecklistGoal checklistGoal && checklistGoal.IsComplete())
            {
                _score += checklistGoal.Points + checklistGoal.Bonus; // Add bonus points if checklist goal is complete
            }
            Console.WriteLine("Event recorded.");
        }
        else
        {
            Console.WriteLine("Invalid goal number. Event not recorded.");
        }
    }

    private void SaveGoals()
    {
        Console.Write("Enter filename to save goals: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved.");
    }

    private void LoadGoals()
    {
        Console.Write("Enter filename to load goals: ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                _score = int.Parse(reader.ReadLine());
                _goals.Clear();

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    string type = parts[0];
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);

                    if (type == "SimpleGoal")
                    {
                        bool isComplete = bool.Parse(parts[4]);
                        var simpleGoal = new SimpleGoal(name, description, points);
                        if (isComplete)
                        {
                            simpleGoal.RecordEvent(); // Mark as complete if necessary
                        }
                        _goals.Add(simpleGoal);
                    }
                    else if (type == "EternalGoal")
                    {
                        _goals.Add(new EnternalGoal(name, description, points));
                    }
                    else if (type == "ChecklistGoal")
                    {
                        int target = int.Parse(parts[4]);
                        int bonus = int.Parse(parts[5]);
                        int amountCompleted = int.Parse(parts[6]);
                        var checklistGoal = new ChecklistGoal(name, description, points, target, bonus)
                        {
                            AmountCompleted = amountCompleted
                        };
                        _goals.Add(checklistGoal);
                    }
                }
            }
            Console.WriteLine("Goals loaded.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}


