public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();


        //getting the word text in an array and splitting them with a space
        string[] wordArray = text.Split(' ');

        /*-creating a new word object with the Word class or blueprint, 
        -iterating through every word in wordArray and injecting it into new word object, 
        -eventually assigning all the word objects to a list */
        foreach (string wordText in wordArray)
        {
            Word word = new Word(wordText);
            _words.Add(word);
        }
    }

    public void HideRandomWord(int numberToHide)
    {
        Random random = new Random();
        for (int i = 0; i < numberToHide; i++)
        {
            int index = random.Next(_words.Count);
            _words[index].Hide();
        }
    }

    public string GetDisplayText()
    {
        string referenceText = _reference.GetDisplayText();
        string wordsText = "";

        foreach (var word in _words)
        {
            wordsText += word.GetDisplayText() + " ";
        }
 
        return referenceText + ": " + wordsText.Trim();
    }


public bool IsCompletelyHidden()
{
    foreach (var word in _words)
    {
        if (!word.IsHidden())
        {
            return false;
        }
    }
    return true;
}

}