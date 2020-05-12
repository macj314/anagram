using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram.Models;

namespace Anagram.Tests{
  [TestClass]
  public class AnagramTest{
    [TestMethod]
    public void AnagramConstructor_CreateInstanceOfAnagram_Anagram(){
      AnagramString newAnagram = new AnagramString("test");
      Assert.AreEqual(typeof(AnagramString), newAnagram.GetType());
    }

    [TestMethod]
    public void GetWord_ReturnWord_string(){
      string word = "beard";
      AnagramString anagram = new AnagramString(word);

      string result = anagram.Word;

      Assert.AreEqual(word, result);
    }
  }
  
}
