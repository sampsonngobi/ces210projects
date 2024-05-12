using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Memorizer App");

        Reference reference = new Reference("1 Nephi", 3, 7);
        Scripture scripture = new Scripture(reference, "And I Nephi said unto my father, I will go and do the things the Lord has commanded, for I know that the Lord giveth no commandments unto the children of men save he shall prepare a way that they may accomplish the things he has commanded them.");

        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("Press Enter to hide random words or 'Q' to quit.");

        while (!scripture.IsCompletelyHidden())
        {

            Console.Write("Press Enter to hide words or Q to quit:");
            var key = Console.ReadKey().Key;

            if (key == ConsoleKey.Enter)
            {
                scripture.HideRandomWords(3);
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("Press Enter to hide more words or 'Q' to quit.");
            }
            else if (key == ConsoleKey.Q)
            {
                Console.WriteLine("\nExiting the Memorizer App.");
                return;
            }

            // var key = Console.ReadKey().Key;
            // if (key == ConsoleKey.Enter)
            // {
            //     scripture.HideRandomWords(1);
            //     Console.Clear();
            //     Console.WriteLine(scripture.GetDisplayText());
            //     Console.WriteLine("Press Enter to hide more words or 'Q' to quit.");
            // }
            // else if (key == ConsoleKey.Q)
            // {
            //     Console.WriteLine("\nExiting the Memorizer App.");
            //     return;
            // }
        }

        Console.WriteLine("\nAll words hidden. Exiting the Memorizer App.");
    }
}
 