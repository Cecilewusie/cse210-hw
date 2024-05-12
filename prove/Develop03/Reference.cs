public class Reference
{
    //This class will store a variable for the book (string), the chapter (int), and the verse (int)
    private string _book;
    private int _chapter;
    private int _verse;
    private int? _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        if (_endVerse.HasValue)
        {
            string refCombined = $"{_book} {_chapter} : {_verse}-{_endVerse}";
            return refCombined;
        }
        else
        {
            string refCombined = $"{_book} {_chapter} : {_verse}";
            return refCombined;
        }
    }


}