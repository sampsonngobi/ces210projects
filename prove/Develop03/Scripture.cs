using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private List<Word> words;
    private Reference reference;

    public Scripture(Reference reference, string text)
    {
        this.reference = reference;
        words = new List<Word>();

        // Split the text into words using space as separator
        string[] wordArray = text.Split(' ');

        // Create Word objects for each word in the text
        foreach (string wordText in wordArray)
        {
            Word word = new Word(wordText);
            words.Add(word);
        }
    }

    public void HideRandomWords(int count)
    {
        Random random = new Random();
        HashSet<int> indices = new HashSet<int>();

        while (indices.Count < count)
        {
            int index = random.Next(words.Count);
            if (!words[index].IsHidden())
            {
                indices.Add(index);
            }
        }

        foreach (int index in indices)
        {
            words[index].Hide();
        }
    }

    public string GetDisplayText()
    {
        string displayText = reference.GetDisplayText() + "\n";

        foreach (var word in words)
        {
            displayText += word.GetDisplayText() + " ";
        }

        return displayText.TrimEnd();
    }

    public bool IsCompletelyHidden()
    {
        return words.All(word => word.IsHidden());
    }
}
