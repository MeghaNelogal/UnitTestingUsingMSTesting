using CoffeeMaker;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace StarBucksTest
{
    [TestClass]
    public class StarBucksUnitTesting
    {
        [TestMethod]
        public void OrderCoffeeFake_InStarBucks_ShouldReturnRecieveMessage()
        {
            StarBuckStore store = new StarBuckStore(new FakeStarBuks());//Arrange
            string actual = store.OrderCoffee(5, 10);
            Assert.AreEqual(actual, "Your Coffee is Recieve");//Assert

        }
        [TestMethod]
        public void OrderCoffeeMoq_InStarBucks_ShouldReturnRecieveMessage()
        {
            var moqService = new Mock<IMakeACoffee>();
            moqService.Setup(y => y.CheckingIngredientsAvailability()).Returns(true);
            moqService.Setup(y => y.CoffeeMaking(5, 10)).Returns("Your Coffee is Recieve");
            StarBuckStore result = new StarBuckStore(moqService.Object);
            string actual = result.OrderCoffee(5, 10);
            Assert.AreEqual(actual, "Your Coffee is Recieve");
        }
        [TestMethod]
        public void OrderCoffeeStub_InStarBucks_ShouldReturnRecieveMessage()
        {
            StarBuckStore store = new StarBuckStore(new FakeStarBuks());
            string actual = store.OrderCoffee(5, 10);
            Assert.AreEqual(actual, "Your Coffee is Recieve");
        }
    }
}

   
  





