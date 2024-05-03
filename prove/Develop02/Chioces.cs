 
 using System;

//Declare a choices class to control users choices
 public class Chioces()

 {

    //This function will run the program
    public void Run()
    {
   
        //Declare a variable to hold the user's choice
        string userChoice = "";

        //add an instance of the journal class
        Journal journal = new Journal();

        //loop through the options until the user quits
        while(userChoice != "5")
        {
            
            //Display and ask user to chose an action
            Console.WriteLine("");
            Console.WriteLine("Please Select from the list of choices:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display your entry");
            Console.WriteLine("3. Save your entry");
            Console.WriteLine("4. Load entrres");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            userChoice = Console.ReadLine();

            //Clear the console and run the appropriate action. it keeps the console clean
            Console.Clear();

            if (userChoice == "1")
            {
                //Add an entry to the journal
                journal.AddEntry();
                
            }
            else if (userChoice == "2")
            {
                //Display the entries
                journal.DisplayEntries();
                
            }

            else if (userChoice == "3")
            {
                //Save the entries to a file name provided by user
                Console.Write("What is the name of the file to save the entry? ");
                
                //you can save the file name to a variable and then use that variable to save the file
                string fileName = Console.ReadLine();
                journal.SaveEntries(fileName);
                
            }
            else if (userChoice == "4")
            {
                //Load the entries from a file name provided by user
                Console.Write("What is the name of the file to load from? ");
                
                //you pass the file name to the LoadEntries method as a parameter
                journal.LoadEntries(Console.ReadLine());
                
            }

            else if (userChoice == "5")
            {
                //Exit the program
                Console.WriteLine("Thank you for using the Journal App");
                break;
            }
            else
            {
                //Invalid entry message
                Console.WriteLine("Invalid entry. Please try again");
                
            }
        
        }
    }
           
 }
 