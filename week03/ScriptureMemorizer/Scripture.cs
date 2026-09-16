public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(w => new Word(w)).ToList();
    }
    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();
        var visible = _words.Where(w =>!w.IsHidden()).ToList();
        for(int i=0; i<numberToHide && visible.Count>0; i++)
        {
            int index = rand.Next(visible.Count);
            visible[index].Hide();
            visible.RemoveAt(index);
        }
    }
    public string GetDisplayText()
    {
        string refText = _reference.GetDisplayText();
        string scriptureText = string.Join(" ", _words.Select(w => w.GetDisplayText()));
        return $"{refText} {scriptureText}";
    }
    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}
