using Microsoft.VisualStudio.TestTools.UnitTesting;
using QueenAttack;

namespace QueenAttack.Tests
{
  [TestClass]
  public class QueenTest
  {
    [TestMethod]
    public void CanAttack_SameYCoordinate_True()
    {
      Queen test = new Queen();
      Assert.AreEqual(true, test.CanAttack('b', 6, 'f', 6));
    }
    [TestMethod]
    public void CanAttack_SameXCoordinate_True()
    {
      Queen test = new Queen();
      Assert.AreEqual(true, test.CanAttack('d', 8, 'd', 3));
    }
    [TestMethod]
    public void CanAttack_Diagonally_True()
    {
      Queen test = new Queen();
      Assert.AreEqual(true, test.CanAttack('a', 5, 'd', 2));
    }
    [TestMethod]
    public void CanAttack_NotValid_False()
    {
      Queen test = new Queen();
      Assert.AreEqual(false, test.CanAttack('a', 1, 'b', 6));
    }

  }
}
