using System; 
namespace RockPaperScissors.Models
{
  public class Game
  {
    public string Player1 { get; set; }
    public string Player2 { get; set;  }

    public Game(string player1, string player2)
    {
      Player1 = player1;
      Player2 = player2;
    }
    public string SelectWinner()
    {
      try
      {
        var  p1Wins = "Player1 wins!";
        var p2Wins = "Player2 wins!";
     
        if(Player1 == "scissors" && Player2 == "paper" )
        {
          return p1Wins;
        }
        else if(Player1 == "paper" && Player2 == "scissors")
        {
          return p2Wins;
        }
        else if(Player1 == "rock" && Player2 == "scissors" )
        {
          return p1Wins;
        }
        else if(Player1 == "scissors" && Player2 == "rock")
        {
          return p2Wins;
        }
        else if(Player1 == "paper" && Player2 == "rock" )
        {
          return p1Wins;
        }
        else if(Player1 == "rock" && Player2 == "paper")
        {
          return p2Wins;
        }
        else if(Player1 == Player2)
        {
          return "It's a tie!";
        }
        else
        {
          throw new Exception();
        }
      }
    catch (Exception e)
      {
          return "Error player choose invalid answer";
      }
      //try or catch maybe
      // rock vs paper == p1 wins
      // paper vs rock == p2
      //scissors vs paper == p1 wins
      //paper vs scissors == p2 wins
      //rock vs scissors == p1 wins
      //scissors vs rock == p2 wins
    }
  }
}