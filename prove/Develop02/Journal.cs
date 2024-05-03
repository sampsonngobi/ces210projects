using System;
using System.IO;
using System.Collections.Generic;


//create a public class for our journal
public class Journal
{
   //Create a list to store our entries
   private List<Entry> _entries = new List<Entry>();

    //Create a method to add an entry to the list
   public void AddEntry()
   {

        //create an instance of the entry class
        Entry _entry = new Entry();

        //generate a random prompt using an instance of the prompts class
        string prompt = new Prompts().GenerateRandomPrompt();
        Console.WriteLine(prompt);

        //get the current date and time
        DateTime theCurrentTime = DateTime.Now;

        //set the properties of the entry class
        _entry._date = theCurrentTime.ToShortDateString();
        _entry._promtText = prompt;
        _entry._entryText = Console.ReadLine();

        //add the entry to the list
        _entries.Add(_entry);

   } 

    //add a method to display the entries
   public void DisplayEntries()
   {
        //loap through the list of entries and display each one
        foreach (Entry entry in _entries)
        {
            //call the display method 
            entry.Display();
        }
       
   }
    //add a method to save the entries
   public void SaveEntries(string fileName)
   {
        
        //string fileName = "journal.csv"; - another way of doing it 

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._promtText}|{entry._entryText}");
            }

        }
        //entrysaved alert
        Console.WriteLine($"Entries saved to file Successfully");

   }

    //add a method to load the entries
   public void LoadEntries(string fileName)
   {
    

        if (File.Exists(fileName))

        {
            //read file and add to list
            string[] lines = File.ReadAllLines(fileName);
            foreach (string line in lines)
            {
                string[] parts = line.Split("|");

                string date = parts[0];
                string promtText = parts[1];
                string entryText = parts[2];

                

                Entry entry = new Entry();
                entry._date = date;
                entry._promtText = promtText;
                entry._entryText = entryText;

                //add to list
                _entries.Add(entry);
            }
            Console.WriteLine("Entries loaded successfully!");

        }
        else
        {
            //erorr message
            Console.WriteLine("File not found. Enter a valid file name!");

        }
        
    }

    public class DeleteEntry()
    {
        
    }
}