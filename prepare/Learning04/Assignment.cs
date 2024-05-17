public class Assignment
{
    private string _studentName;
    private string _topic;

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string getStudentName()
    {
        return _studentName;
    }
    // public void setStudentName(string student)
    // {
    //     _studentName = student;
    // }
    // public string getTopic()
    // {
    //     return _topic;
    // }
    // public void setTopic(string topic)
    // {
    //     _topic =  topic;
    // }

    public string getSummary()
    {
        //return $"{getStudentName()} {getTopic()}";
        return $"{_studentName} -- {_topic}";
    }    

}