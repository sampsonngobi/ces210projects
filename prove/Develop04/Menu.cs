using System;

public class Menu
{
    public void Main()
    {
        string userResponse = "";

        while (userResponse != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options");
            Console.WriteLine("1. Start Breathing activity");
            Console.WriteLine("2. Start Reflecting activity");
            Console.WriteLine("3. Start Listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Enter a number to start a mindful activity: ");
            userResponse = Console.ReadLine();
            
            if (userResponse == "1")
            {
                // Start Breathing Activity
                BreathingActivity breathingActivity = new BreathingActivity("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", 10);
                breathingActivity.Run();
            }

            else if(userResponse == "2")
            {
                // Start Reflecting Activity
                ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 10);
                reflectingActivity.Run();
            }

            else if(userResponse == "3")
            {
                //start Listing activity
               ListingActivity listingActivity = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 10);
               listingActivity.Run();
            }

            else if(userResponse == "4")
            {
                //Quit
                Console.WriteLine("\nThank you for using our app! Goodbye! ");
            }

            else
            {   //handle input error
                Console.WriteLine("\nInvalid option entered. Please try again. ");
            }
        

        }
    }
}