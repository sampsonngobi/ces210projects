using System;
using System.Collections.Generic;

//Here is where I will store all of the prompts that I will use for the journal entries
public class Prompts
{
    //Our prompt list
   public List<string> _promptList = new List<string>{
        "What was the best part of my day?",
        "What was the worst part of my day?",
        "What did I do today that made me happy?",
        "How did I represent the saviourtoday?",
        "What did I do to serve someone today?",
        "Who was the most interesting person I interacted with today?",
        "If I had one thing I could do over today, what would it be?",
        "What was the most important thing I did today?"
    };

    //This is the method that will generate a random prompt from the list
    private Random rand = new Random();
    public string GenerateRandomPrompt()
    {
        int randomIndex = rand.Next(_promptList.Count);
        return  _promptList[randomIndex];
    }
   
}