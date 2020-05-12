using System.Collections.Generic;
using System;
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

    public static List<string> Compare(List<string> list, string str){
      
      List<string> resultList = new List<string>{};
      for (int i = 0; i < list.Count; i++){
        bool isAnagram = Checker(list[i],str);
        if (isAnagram){
          resultList.Add(list[i]);
        }
      }
      return resultList;
    }
    public static bool Checker(string word1, string word){
      if (word1.Length != word.Length){
        return false;
      }
      char[] charArray1 = word1.ToLower().ToCharArray();
      char[] charArray2 = word.ToLower().ToCharArray();
      Array.Sort(charArray1);
      Array.Sort(charArray2);

      string newWord1 = string.Join("",charArray1);
      string newWord2 = string.Join("",charArray2);
      bool value = (newWord1 == newWord2)? true : false;
      
      return value;
    }
  }
}