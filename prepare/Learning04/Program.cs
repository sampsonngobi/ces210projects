using System;

class Program
{
    static void Main(string[] args)
    {
    
        Assignment a1 = new Assignment("Sampson Ngobi", "Addition");
        
        Console.WriteLine(a1.GetSummary());
        
        MathAssignment a2 = new MathAssignment("Salvador Ngobi", "Fractions", "7.4", "10-15");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Victoria Ngobi", "Chemistry", "The Periodic Table");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    
    }
}