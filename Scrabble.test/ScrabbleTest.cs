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
  }
}
