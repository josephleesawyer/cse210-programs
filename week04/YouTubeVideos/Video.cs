using System;

public class Video
{
    private string _title;
    private string _author;
    private int _seconds;
    private List<Comment> _comments = new();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _seconds = length;
    }
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }    
    public int NumComments()
    {
        return _comments.Count;
    }
    public string VidAndComDisplay()
    {
        string display = $"\r\n\r\n{_title}, by {_author}   ({_seconds} sec)";
        display += $"\r\nComments ({NumComments()}): ";
        foreach (Comment comment in _comments)
        {
            display += $"\r\n\r\n{comment.ComDisplay()}";
        }
        return display;
    }

}