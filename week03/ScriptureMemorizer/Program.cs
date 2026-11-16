using System;

/*
 * EXCEEDING REQUIREMENTS:
 * 1. Stretch challenge: random words are chosen only from words that are not already hidden.
 * 2. Scripture library: a scripture is chosen at random from a library (ScriptureLibrary class).
 * 3. Punctuation (commas, periods, etc.) stays visible when a word is hidden, which makes the
 *    sentence structure easier to follow while practicing. Each letter is still replaced by
 *    one underscore.
 */
class Program
{
    static void Main(string[] args)
    {
        ScriptureLibrary library = new ScriptureLibrary();
        Scripture scripture = library.GetRandomScripture();
        bool quit = false;

        while (!quit && !scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.Write("Press enter to continue or type 'quit' to finish: ");
            string input = Console.ReadLine();

            if (input != null && input.Trim().ToLower() == "quit")
            {
                quit = true;
            }
            else
            {
                scripture.HideRandomWords(3);
            }
        }

        if (!quit)
        {
            // Final display with every word hidden, then the program ends
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
        }
    }
}
