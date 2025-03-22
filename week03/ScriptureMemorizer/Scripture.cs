using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();


    //Creating Constructor
    public Scripture(Reference reference, string scriptureText)
    {
        _reference = reference;
        _words = new List<Word>();

        //Creating the list of words on the scripture and separating the words on each space within words that is found
        string[] listOfWords = scriptureText.Split(' ');

        foreach (string wordText in listOfWords)
        {
            Word word = new Word(wordText);
            
            //Adding the scripture words as objects in the Words class

            _words.Add(word);
        }

    }


    //Creating a getter for the list of Words:
    public List<Word> GetWords()
    {
        return _words;
    }

    //Creating methods
    public void HideRandomWords(int numberToHide)
    {   
        //Keeping track of how many words have been hidden
        int hiddenCount = 0;
        int attempts = 0;

        while (hiddenCount < numberToHide && attempts < _words.Count * 2)
        {
            int index = _random.Next(_words.Count);
            Word word = _words[index];

            if (word.IsHidden() == false) 
            {
                word.Hide();
                hiddenCount++;
            }

            attempts++;
        }    

    }

    public string GetDisplayText()
    {
        //Creating a list to store the display text of each word
        List<string> displayedWords = new List<string>();

        //Going thorugh each word object and get its display text
        foreach (Word word in _words)
        {
            displayedWords.Add(word.GetDisplayText());
        }

        // Join all the words with a space between them and return the resulting string
        return string.Join(" " , displayedWords);
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                return false;
            }
        }
        return true;
    }

    
}