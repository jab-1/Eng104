using NUnit.Framework;
using Operators;

namespace OperatorsControlFlowTests
{
    public class StoneTests
    {
        //11 stones
        [TestCase(156, 11)]
        //10 stones exactly
        [TestCase(140, 10)]
        //Less than 14 pounds
        [TestCase(8, 0)]
        //Lower boundary
        [TestCase(0, 0)]
        public void GivenANumberOfPounds_GetStones_ReturnTheCorrectNumberOfStones(int pounds, int expStones)
        {
            var result = Methods.GetStones(pounds);
            Assert.That(result, Is.EqualTo(expStones));
        }

        //2 pounds left over
        [TestCase(156, 2)]
        //0 pounds left over
        [TestCase(140, 0)]
        //8 pounds left over, less than 14 pounds (1 stone)
        [TestCase(8, 8)]
        //lower boundary
        [TestCase(0, 0)]
        public void GivenANumberOfPounds_GetPounds_ReturnTheCorrectNumberOfPounds(int pounds, int expPounds)
        {
            var result = Methods.GetPounds(pounds);
            Assert.That(result, Is.EqualTo(expPounds));
        }
    }
}