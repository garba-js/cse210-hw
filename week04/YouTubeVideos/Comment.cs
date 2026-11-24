
public class Comment
{
    // Member variables
    private string _authorName;
    private string _text;

    // Constructor
    public Comment(string authorName, string text)
    {
        _authorName = authorName;
        _text = text;
    }

    // Display the commenter's name and comment
    public void Display()
    {
        Console.WriteLine($"    {_authorName}: {_text}");
    }
}
