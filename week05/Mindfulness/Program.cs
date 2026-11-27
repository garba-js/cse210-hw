
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");

        int choice = 0;

        Console.WriteLine("Welcome to the Mindfulness Program!");

        while (choice != 4)
        {
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");

            string input = Console.ReadLine();

            if (!int.TryParse(input, out choice))
            {
                Console.WriteLine("Please enter a valid number.");
                continue;
            }

            if (choice == 1)
            {
                BreathingActivity activity = new BreathingActivity();
                activity.Run();

                SaveActivityHistory(activity.GetName(), activity.GetDuration());
            }
            else if (choice == 2)
            {
                ReflectingActivity activity = new ReflectingActivity();
                activity.Run();

                SaveActivityHistory(activity.GetName(), activity.GetDuration());
            }
            else if (choice == 3)
            {
                ListingActivity activity = new ListingActivity();
                activity.Run();

                SaveActivityHistory(activity.GetName(), activity.GetDuration());
            }
            else if (choice == 4)
            {
                Console.WriteLine("Thank you for using the Mindfulness Program. Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select 1, 2, 3, or 4.");
            }
        }
    }

    // EXTRA FEATURE:
    // This method saves completed activities and their durations
    // in a history file so users can keep track of their sessions.
    static void SaveActivityHistory(string activityName, int duration)
    {
        string record = $"{DateTime.Now}: {activityName} - {duration} seconds";

        File.AppendAllText("activity_history.txt", record + Environment.NewLine);
    }
}
