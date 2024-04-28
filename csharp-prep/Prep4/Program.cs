using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = -1;

        while (number != 0)
        {
            Console.Write("Enter a number (Enter 0 to quit): ");
            String userNumber = Console.ReadLine();
            number = int.Parse(userNumber);

            // AddingNewEventArgs number to list expect 0
            if (number != 0)
            {
                numbers.Add(number);
            }
              
        }

        
        
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
           
        }
        Console.WriteLine($"The sum is: {sum}");

        float average = (float)sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");


        int LargestNumber = numbers.Max();
        Console.WriteLine($"The largest number is: {LargestNumber}");
        
    }
}