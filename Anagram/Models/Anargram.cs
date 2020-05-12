using System.Collections.Generic;
namespace Anagram.Models{
  public class AnagramString{
   
    public string Word {get;set;}
    private static List<string> _wordList = new List<string>(){};
    public AnagramString(string words, string word){
      _wordList.Add(words);
      Word = word;
    }
    
    public static List<string> GetAll(){
      return _wordList;
    }

    public static void ClearAll()
    {
      _wordList.Clear();
    }
  }
}