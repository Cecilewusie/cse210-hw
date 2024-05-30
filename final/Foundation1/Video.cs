using System.ComponentModel;
using System.Text;

public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _commentList = new List<Comment>();

    public Video(string title, string author, int Lenght)
    {
        _title = title;
        _author = author;
        _length = Lenght;    
    }

    public void DisplayVideoInfo()
    {
            Console.WriteLine($"Author: {_author}");
            Console.WriteLine($"Tile: {_title}");
            Console.WriteLine($"Lenght: {_length}");
            Console.WriteLine();
        
    }

    public List<string> GetComment()
    {
        List<string> comments = new List<string>();
        foreach (Comment com in _commentList)
        {
            string comm = com.CommentRepresentation();
            comments.Add(comm);
        }
        return comments;
    }

    public void DisplayComment()
    {
        foreach (string c in GetComment())
        {
            Console.WriteLine(c);
        }
    }

    public int NumberOfComment()
    {
        return _commentList.Count();
    }


}