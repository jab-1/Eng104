using CodeToTest;
using NUnit.Framework;
using System;

namespace Tests
{
    public class Tests
    {

        [TestCase(19)]
        [TestCase(21)]
        [TestCase(24)]
        public void GivenATimeGreaterThan18_Greeting_ReturnsGoodEvening(int time)
        {
            // Arrange
            var expectedGreeting = "Good evening!";
            // Act
            var result = Program.Greeting(time);
            // Assert
            Assert.That(result, Is.EqualTo(expectedGreeting));
        }

        [TestCase(5)]
        [TestCase(8)]
        [TestCase(12)]
        public void GivenATimeBetween5and12Inclusive_Greeting_ReturnsGoodMorning(int time)
        {
            // Arrange
            var expectedGreeting = "Good morning!";
            // Act
            var result = Program.Greeting(time);
            // Assert
            Assert.That(result, Is.EqualTo(expectedGreeting));
        }

        [TestCase(13)]
        [TestCase(15)]
        [TestCase(18)]
        public void GivenATimeBetween13And18_Greeting_ReturnsGoodAfternoon(int time)
        {
            Assert.That(Program.Greeting(time), Is.EqualTo("Good afternoon!"));
        }

        [TestCase(0)]
        [TestCase(2)]
        [TestCase(4)]
        public void GivenATimeBetween0and4_Greeting_ReturnsGoodEvening(int time)
        {
            Assert.That(Program.Greeting(time), Is.EqualTo("Good evening!"));
        }

        [Category("Edge Case")]
        [TestCase(12, "Good morning!")]
        [TestCase(13, "Good afternoon!")]
        [TestCase(18, "Good afternoon!")]
        [TestCase(19, "Good evening!")]
        public void GivenANumber_Greeting_ReturnsCorrectGreeting(int time, string expected)
        {
            Assert.That(Program.Greeting(time), Is.EqualTo(expected));
        }

        [TestCase(-1)]
        [TestCase(25)]
        public void GivenATimeLessThan0OrMoreThan24_Greeting_ReturnsCorrectGreeting(int time)
        {
            Assert.That(() => Program.Greeting(time), Throws.Exception);
            Assert.That(() => Program.Greeting(time), Throws.TypeOf<Exception>().With.Message.EqualTo("Invalid value"));
        }
    }
}
