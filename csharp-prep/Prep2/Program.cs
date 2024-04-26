using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your garde percentage? ");
        string input = Console.ReadLine();
        int grade = int.Parse(input);

        string letter = "";

        // if (grade >= 90)
        //     {
        //         Console.WriteLine("You got an A!");
        //     }
        // else if (grade >= 80)
        //     {
        //         Console.WriteLine("You got a B!");
        //     }
        // else if (grade >= 70)
        //     {
        //         Console.WriteLine("You got a C!");
        //     }
        // else if (grade >= 60)
        //     {
        //         Console.WriteLine("You got a D!");
        //     }
        // else if (grade < 60)
        //     {
        //         Console.WriteLine("You got an F!");
        //     }

        if (grade >= 90)
            {
                letter = "an A";
            }
        else if (grade >= 80)
            {
                letter = "a B";
            }
        else if (grade >= 70)
            {
                 letter = "a C";
            }
        else if (grade >= 60)
            {
                 letter = "a D";
            }
        else if (grade < 60)
            {
                 letter = "an F";
            }
        Console.WriteLine ($"You got {letter} ");
     
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed!");
        }
        else
        {
            Console.WriteLine("Don't give up! you've got this.");
        }

        
    }
}