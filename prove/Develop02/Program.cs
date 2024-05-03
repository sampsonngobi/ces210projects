using System;
using System.Runtime.InteropServices.Marshalling;


// To exceed expectation I have added a new class called "Chioces"
// which is the main class of the program. 
// I also added a function that clears the terminal and makes it much more readable. 

class Program
{
    static void Main(string[] args)
    {
        //instance of the choices class
        Chioces choose = new Chioces();
        //this method runs the program
        choose.Run();
 
       
    }

}