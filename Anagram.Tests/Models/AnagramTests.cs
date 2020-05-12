using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram.Models;

namespace Anagram.Tests{
  [TestClass]
  public class AnagramTest : IDisposable{
    public void Dispose(){
      AnagramString.ClearAll();
    }

    [TestMethod]
    public void AnagramConstructor_CreateInstanceOfAnagram_Anagram(){
      AnagramString newAnagram = new AnagramString("cat", "tac");
      Assert.AreEqual(typeof(AnagramString), newAnagram.GetType());
    }

    [TestMethod]
    public void GetWord_ReturnWord_String(){
      string words = "beard";
      string word = "beard";
      AnagramString anagram = new AnagramString(words,word);

      string result = anagram.Word;
      List<string> listResult = new List<string>{};
      listResult = AnagramString.GetAll();

      Assert.AreEqual(word, result);
      Assert.AreEqual(words, listResult[0]);
    }

    [TestMethod]
    public void Compare_ReturnListOfAnagrams_List()
    {
      string listItem = "bad";
      string word = "dab";
      AnagramString anagram = new AnagramString(listItem,word);

      List<string> listResult = new List<string>{};
      listResult = AnagramString.GetAll();
      listResult = AnagramString.Compare(listResult, word);

      Assert.AreEqual(listItem, listResult[0]);
    }
  }
  
}
