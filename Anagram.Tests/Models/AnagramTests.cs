using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram.Models;

namespace Anagram.Tests{
  [TestClass]
  public class AnagramTest{
    [TestMethod]
    public void AnagramConstructor_CreateInstanceOfAnagram_Anagram(){
      AnagramString newAnagram = new AnagramString();
      Assert.AreEqual(typeof(AnagramString), newAnagram.GetType());
    }

  }
  
}
