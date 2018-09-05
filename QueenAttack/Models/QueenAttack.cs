using System;
using System.Collections.Generic;

namespace QueenAttack
{
  public class Queen
  {
    public bool CanAttack(char inputX, int inputY, char queenX, int queenY)
    {
      Dictionary<char, int> xDict = new Dictionary<char, int>()
      {
        {'a', 1},
        {'b', 2},
        {'c', 3},
        {'d', 4},
        {'e', 5},
        {'f', 6},
        {'g', 7},
        {'h', 8}
      };
      if (inputY == queenY)
      {
        return true;
      }
      else if (inputX == queenX)
      {
        return true;
      }
      else if (Math.Abs(queenY - inputY) == Math.Abs(xDict[queenX] - xDict[inputX]))
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}
