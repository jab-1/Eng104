using ExceptionsApp;
using ExpceptionsApp;
using NUnit.Framework;
using System;

namespace ExceptionTests
{
    public class GradeTests
    {
        [TestCase(-34)]
        [TestCase(-1)]
        public void WhenTheMarkIsLessThanZero_Grade_ThrowsAnArgumentOutOfRangeException(int mark)
        {
            Assert.That(() => Program.Grade(mark), Throws.TypeOf<GradeException>()
                .With.Message.Contain("Allowed range 0-100"));
        }
    }
}