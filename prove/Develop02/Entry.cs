using System;

//Declare an entry class
public class Entry
{
    // the constructor of the entry class
   public string _date; 
   public string _promtText;
   public string _entryText;
   
   // the object of the entry class displays entries 
   public void Display()
   {
    Console.WriteLine("");
    Console.WriteLine($"{_date} {_promtText}");
    Console.WriteLine($"{_entryText}");
   }
}