public class MathAssignment : Assignment
{
    
    private string _textBooksection;  //eg 7.3
    private string _problems; //eg 3-10, 20-21

    public MathAssignment(String studentName, string topic, string textBooksection, string problems) : base(studentName, topic)
    {
        _textBooksection = textBooksection;
        _problems = problems;
    }

    public string getHomeworkList()
    {
        return $"Section {_textBooksection} Problems {_problems}";
    }
}