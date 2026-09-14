using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] words = text.Split(' ');
        foreach (string w in words)
        {
            _words.Add(new Word(w));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int count = 0;
        // Make sure we don't try to hide more than available visible words
        int visibleCount = 0;
        foreach (Word w in _words)
        {
            if (!w.IsHidden()) visibleCount++;
        }
        if (visibleCount == 0) return;

        int toHide = Math.Min(numberToHide, visibleCount);

        while (count < toHide)
        {
            int index = random.Next(_words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                count++;
            }
        }
    }

    public string GetDisplayText()
    {
        string display = _reference.GetDisplayText() + " ";
        foreach (Word w in _words)
        {
            display += w.GetDisplayText() + " ";
        }
        return display;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word w in _words)
        {
            if (!w.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}
