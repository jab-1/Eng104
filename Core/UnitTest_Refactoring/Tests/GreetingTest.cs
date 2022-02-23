using CodeToTest;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void GivenATimeOf21_Greeting_ReturnsGoodEvening()
        {
            //Arrange
            var time = 21;
            var expected = "Good evening!";
            //Act
            var result = Program.Greeting(time);
            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}