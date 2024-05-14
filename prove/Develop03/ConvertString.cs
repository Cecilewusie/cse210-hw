public class ConverString
{
    string _receiveString;

    public ConverString(string recievestring)
    {
        _receiveString = recievestring;
    }

    public int getInt()
    {
        int stringConverted = int.Parse(_receiveString);
        return stringConverted;
    }
}