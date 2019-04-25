using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using ScrabbleSpace;

namespace ScrabbleTests
{
  [TestClass]
  public class TestMethods
  {
    [TestMethod]
    public void TestSingleLetter_InputF_ReturnFour()
    {
      Scrabble scrabble = new Scrabble();
      Assert.AreEqual(4, scrabble.GetWordScore("F"));
    }
    [TestMethod]
    public void TestSingleLowerLetter_Inputf_ReturnFour()
    {
      Scrabble scrabble = new Scrabble();
      Assert.AreEqual(4, scrabble.GetWordScore("f"));
    }

    [TestMethod]
    public void TestWholeWords_InputApple_Return_Nine()
    {
      Scrabble scrabble = new Scrabble();
      Assert.AreEqual(9, scrabble.GetWordScore("apple"));
      Assert.AreEqual(9, scrabble.GetWordScore("ApPle"));
    }

    [TestMethod]
    public void TestSpecialCharacters()
    {
      Scrabble scrabble = new Scrabble();
      Assert.AreEqual(33, scrabble.GetWordScore("H@xz0r3z"));
    }


    [TestMethod]
    public void TestMultipleWords()
    {
      Scrabble scrabble = new Scrabble();
      Assert.AreEqual(9, scrabble.GetWordScore("Apple Juice"));
    }

    [TestMethod]
    public void TestMultipleWordsHyphen()
    {
      Scrabble scrabble = new Scrabble();
      Assert.AreEqual(9, scrabble.GetWordScore("Apple-juice"));      
    }
  }
}
