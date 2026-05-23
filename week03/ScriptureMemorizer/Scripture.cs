using System;
using System.Collections.Generic;

class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        string[] allWords = text.Split(' ');

        foreach (string wordText in allWords)
        {
            _words.Add(new Word(wordText));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int wordsHidden = 0;

        int visibleWordsCount = 0;
        foreach (Word w in _words)
        {
            if (!w.IsHidden()) visibleWordsCount++;
        }

        
        if (numberToHide > visibleWordsCount)
        {
            numberToHide = visibleWordsCount;
        }

        
        while (wordsHidden < numberToHide)
        {
        
            int randomIndex = random.Next(_words.Count);

            if (!_words[randomIndex].IsHidden())
            {
                _words[randomIndex].Hide();
                wordsHidden++;
            }
        }
    }

    public string GetDisplayText()
    {
    
        List<string> wordsToDisplay = new List<string>();

        foreach (Word w in _words)
        {
            wordsToDisplay.Add(w.GetDisplayText());
        }

        
        return $"{_reference.GetDisplayText()} - {string.Join(" ", wordsToDisplay)}";
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