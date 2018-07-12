using System;
using System.Collections.Generic;
// IMPORT LIBRARY PACKAGES NEEDED BY YOUR PROGRAM
// SOME CLASSES WITHIN A PACKAGE MAY BE RESTRICTED
// DEFINE ANY CLASS AND METHOD NEEDED
// CLASS BEGINS, THIS CLASS IS REQUIRED
public class Program
{
	// METHOD SIGNATURE BEGINS, THIS METHOD IS REQUIRED
	public static List<String> retrieveMostFrequentlyUsedWords(String literatureText, 
	                                               List<String> wordsToExclude)
	{
        List<string> result = new List<string>();
	    Dictionary<string, int> wordsSaved = new Dictionary<string, int>();
		string[] words = CleanWord(literatureText).Split(' ');
		
		foreach(string word in words)
        {
            if(!wordsToExclude.Contains(word))
            {
                string cleanedWord = CleanWord(word);
                if(wordsSaved.ContainsKey(cleanedWord))
                {
                    wordsSaved[word.ToLower()]++;
                }
                else
                {
                    wordsSaved.Add(cleanedWord, 1);
                }
            }
		}
		
        foreach(KeyValuePair<string, int> wordSaved in wordsSaved)
        {
            if(wordSaved.Value > 1)
                result.Add(wordSaved.Key);
        }

        return result;
	}

    public static string CleanWord(string word)
    {
        List<char> charactersToRemove = new List<char>();
        string wordCleaned = word.ToLower();

        foreach(char letter in wordCleaned)
        {
            if((int)letter < 97 
                || (int)letter > 122)
            {
                charactersToRemove.Add(letter);
            }
        }

        foreach(char character in charactersToRemove)
        {
            wordCleaned = wordCleaned.Replace(character, ' ');
        }

        return wordCleaned.Trim();
    }
	// METHOD SIGNATURE ENDS

    static void Main(string[] args) {
        string word = "Jack and Jill went to the market to buy bread and cheese. Cheese is Jack's and Jill's favorite food.";
        List<string> exclude = new List<string>();
        exclude.Add("and");
        exclude.Add("he");
        exclude.Add("the");
        exclude.Add("to");
        exclude.Add("is");  
        List<string> result = retrieveMostFrequentlyUsedWords(word, exclude);
    }
}