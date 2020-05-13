using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors.Models;
using System;

namespace Roshambo.Tests
{
  [TestClass]
  public class Tests
  {
    [TestMethod]
    public void Roshambo_SelectWinner()
    {
      //arrange
      Game newGame = new Game("scissors","paper");
      //act
      string result = newGame.SelectWinner();
      //assert
      Console.WriteLine(result + "      ");
      Assert.AreEqual( "Player1 wins!", result);
    }
    [TestMethod]
    public void Roshambo_SelectWinner_Player2Wins()
    {
      //arrange
      Game newGame = new Game("scissors","rock");
      //act
      string result = newGame.SelectWinner();
      //assert
      Console.WriteLine(result + "      ");
      Assert.AreEqual( "Player2 wins!", result);
    }
    [TestMethod]
    public void Roshambo_SelectWinner_Player1CoosesRockVsPaper_P1Wins()
    {
      //arrange
      Game newGame = new Game("paper","rock");
      //act
      string result = newGame.SelectWinner();
      //assert
      Console.WriteLine(result + "      ");
      Assert.AreEqual( "Player1 wins!", result);
    }
    [TestMethod]
    public void Roshambo_SelectWinner_TryWorks()
    {
      //arrange
      Game newGame = new Game("paper","paper");
      //act
      string result = newGame.SelectWinner();
      //assert
      Console.WriteLine(result + "      ");
      Assert.AreEqual("It's a tie!", result);
    }
    [TestMethod]
    public void Roshambo_SelectWinner_CatchWorks()
    {
      //arrange
      Game newGame = new Game("hello","paper");
      //act
      string result = newGame.SelectWinner();
      //assert
      Console.WriteLine(result + "      ");
      Assert.AreEqual("Error player choose invalid answer", result);
    }
  }
}