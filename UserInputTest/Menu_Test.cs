using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BattleShipV2
{
    [TestClass]
    public class Menu_Test
    {
        [TestMethod]
        public void TestMethod_StartGame_True()
        {
            Assert.AreEqual(true, Menu.StartGameChoice("yes"));
        }
    }
}
