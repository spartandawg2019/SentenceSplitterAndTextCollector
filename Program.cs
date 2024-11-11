using System;
using System.Collections.Generic;

class SentenceSplitter
{
    // This method splits a sentence into words and displays each word on a new line
    public void RunSentenceSplitter()
    {
        string continueChoice = "y"; // Controls the loop

        while (continueChoice.ToLower() == "y")
        {
            Console.Write("Enter a sentence: ");
            string userSentence = Console.ReadLine();

            // Split the sentence into words by spaces
            string[] wordsArray = userSentence.Split(' ');

            // Display each word on a separate line
            foreach (string word in wordsArray)
            {
                Console.WriteLine(word);
            }

            // Ask if the user wants to continue
            Console.Write("Would you like to continue (y/n)? ");
            continueChoice = Console.ReadLine();
        }

        Console.WriteLine("Goodbye!");
    }
}

class TextCollector
{
    // This method collects multiple user inputs, stores them in a list, and displays them
    public void RunTextCollector()
    {
        List<string> userInputs = new List<string>(); // Stores each input from the user
        string continueChoice = "y"; // Controls the loop

        while (continueChoice.ToLower() == "y")
        {
            Console.Write("Enter some text: ");
            string userInput = Console.ReadLine();

            // Add the user input to the list
            userInputs.Add(userInput);

            // Display all inputs so far, joined by spaces
            Console.WriteLine("You have entered: " + string.Join(" ", userInputs));

            // Ask if the user wants to continue
            Console.Write("Would you like to continue (y/n)? ");
            continueChoice = Console.ReadLine();
        }

        Console.WriteLine("Goodbye!");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Choose a task:");
        Console.WriteLine("1 - Split a sentence into individual words");
        Console.WriteLine("2 - Collect and display user-entered text");
        Console.Write("Enter your choice (1 or 2): ");

        string choice = Console.ReadLine();

        if (choice == "1")
        {
            SentenceSplitter sentenceSplitter = new SentenceSplitter();
            sentenceSplitter.RunSentenceSplitter();
        }
        else if (choice == "2")
        {
            TextCollector textCollector = new TextCollector();
            textCollector.RunTextCollector();
        }
        else
        {
            Console.WriteLine("Invalid choice. Exiting the program.");
        }
    }
}