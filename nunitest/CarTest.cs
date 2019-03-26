using NUnit.Framework;
using Moq;

namespace nunitest
{
    [TestFixture]
    class CarTest
    {
        [Test]
        public void GetCarDetailsTest()
        {
            int value = 1;

            Mock<ICarDetails> carDetails = new Mock<ICarDetails>();
            carDetails.Setup(x => x.GetDetails(It.IsAny<int>())).Returns("BMW");

            var car = new Car(carDetails.Object);

            Assert.That(car.GetCarDetails(value), Is.EqualTo("BMW, That's a great car!"));
        }
    }
}
