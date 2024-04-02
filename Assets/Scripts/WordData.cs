public class WordData
{
    private readonly string _word;
    private readonly string _translate;

    public string Word { get => _word; }
    public string Translate { get => _translate; }

    public WordData(string word, string translate)
    {
        _word = word;
        _translate = translate;
    }
}