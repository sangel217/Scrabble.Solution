using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Score.Models;
using System.Collections.Generic;
using System.Linq;


namespace Score.Tests
{
  [TestClass]
  public class PointsTests
  {

    [TestMethod]
    public void ScrabbleConstructor_SetsInstanceOfWord_Points()
    {
      Points newWord = new Points("test");
      Assert.AreEqual(typeof(Points), newWord.GetType());
    }

    [TestMethod]
    public void CollectWord_ReturnWord_String()
    {
      string word = "hello";
      Points newWord = new Points(word);
      string result = newWord.CollectWord();
      Assert.AreEqual(word, result);
    }

    [TestMethod]
    public void LowerCase_MakeWordLowerCase_String()
    {
      string word = "HELLO";
      Points newWord = new Points(word);
      string updatedWord = newWord.LowerCase();
      string expectedWord = "hello";
      Assert.AreEqual(updatedWord, expectedWord);
    }

    [TestMethod]
    public void ConvertString_ReturnArray_CharArray()
    {
      Points newWord = new Points("hello");
      char[] resultExpected = new char[] {'h', 'e', 'l', 'l', 'o'};
      CollectionAssert.AreEqual(resultExpected, newWord.ConvertString("hello"));
    }

  }
}
