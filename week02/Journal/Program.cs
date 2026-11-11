// ==========================================
// CSE 210: Journal Program
// Author: Garba Joseph Samson
// Exceeding Requirements Description:
// I implemented a keyword search feature that allows 
// users to search through all journal entries. The 
// search checks case-insensitively across the entry text, 
// prompt text, and date, displaying all matching results.
// ==========================================

using System;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();
        int choice = 0;

        while (choice != 6)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save journal to a file");
            Console.WriteLine("4. Load journal from a file");
            Console.WriteLine("5. Search journal entries"); // New menu option
            Console.WriteLine("6. Quit");
            Console.Write("What would you like to do? ");
            
            string input = Console.ReadLine();
            if (int.TryParse(input, out choice))
            {
                if (choice == 1)
                {
                    string prompt = promptGen.GetRandomPrompt();
                    Console.WriteLine($"\nPrompt: {prompt}");
                    Console.Write("> ");
                    string userText = Console.ReadLine();

                    Entry newEntry = new Entry();
                    newEntry._date = DateTime.Now.ToShortDateString();
                    newEntry._promptText = prompt;
                    newEntry._entryText = userText;

                    theJournal.AddEntry(newEntry);
                    Console.WriteLine("Entry added successfully!\n");
                }
                else if (choice == 2)
                {
                    Console.WriteLine("\n--- Journal Entries ---");
                    theJournal.DisplayAll();
                }
                else if (choice == 3)
                {
                    Console.Write("Enter filename to save (e.g., myJournal.txt): ");
                    string filename = Console.ReadLine();
                    theJournal.SaveToFile(filename);
                }
                else if (choice == 4)
                {
                    Console.Write("Enter filename to load: ");
                    string filename = Console.ReadLine();
                    theJournal.LoadFromFile(filename);
                }
                else if (choice == 5) // Handle search input
                {
                    Console.Write("Enter a keyword or date to search for: ");
                    string keyword = Console.ReadLine();
                    theJournal.SearchEntries(keyword);
                }
                else if (choice == 6)
                {
                    Console.WriteLine("Goodbye!");
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please pick between 1 and 6.\n");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.\n");
            }
        }
    }
}