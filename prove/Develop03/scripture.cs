public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random;

    public bool AllWordsHidden { get { return _words.All(w => w.Hidden); } }

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        _random = new Random();

        string[] wordArray = text.Split(' ');

        foreach (string word in wordArray)
        {
            _words.Add(new Word(word));
        }
    }

    public void Display()
    {
        try
        {
            Console.Clear();
        }
        catch (System.IO.IOException)
        {
        }

        Console.WriteLine(_reference.ToString());

        int wordCount = 0;
        foreach (Word word in _words)
        {
            if (wordCount >= 15)
            {
                Console.WriteLine();
                wordCount = 0;
            }

            Console.Write(word.Hidden ? "***** " : word.Text + " ");
            wordCount++;
        }

        Console.WriteLine();
    }

    public void HideRandomWord()
    {
        int index = _random.Next(_words.Count);
        _words[index].Hide();
    }
}