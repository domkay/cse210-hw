public class ScriptureLibrary
{
    private List<Scripture> _scriptures;
    private Random _random;
    public ScriptureLibrary()
    {
        _scriptures = new List<Scripture>();
        _random = new Random();
        AddScripture(new Reference("John", 3, 16), "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
        AddScripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.");
        AddScripture(new Reference("Philippians", 4, 13), "I can do all things through Christ who strengthens me.");
        AddScripture(new Reference("Psalm", 23, 1), "The Lord is my shepherd; I shall not want.");
    }
    private void AddScripture(Reference reference, string text)
    {
        _scriptures.Add(new Scripture(reference, text));
    }
    public Scripture GetRandomScripture()
    {
        int index = _random.Next(_scriptures.Count);
        return _scriptures[index];
    }
}