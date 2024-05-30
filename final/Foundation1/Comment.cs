public class Comment
{
    public string _nameOfPerson;
    public string _textOfComment;

    public Comment(string nameOfPerson, string textOfComment)
    {
        _nameOfPerson = nameOfPerson;
        _textOfComment = textOfComment;
    }

    public string CommentRepresentation()
    {
        string commentInfo =  $"{_nameOfPerson}: {_textOfComment}";
        return commentInfo;
    }
}