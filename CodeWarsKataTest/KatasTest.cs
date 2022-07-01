
using CodeWarsKata;

namespace CodeWarsKataTest
{
    public class KatasTest
    {
        private static Katas _katas;

        [SetUp]
        public void Setup()
        {
            _katas = new Katas();
        }

        [Test]
        public void Given_A_Sentence_When_Counting_Length_Of_Each_Word_Should_Return_ShortestWordLength()
        {
            //Arrange
            var sentenceInput = "Njabulo is doing katas";
            var expected = 2;
            //Act
            var actual = _katas.FindShort(sentenceInput);
            //Asset
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Given_A_Sentence_When_Counting_Length_Of_Each_Word_Should_Return_ShortestWordLength_2()
        {
            //Arrange
            var sentenceInput = "Njabulo is doing katas";
            var expected = 2;
            //Act
            var actual = _katas.FindShortTwo(sentenceInput);
            //Asset
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Given_A_Sentence_When_Counting_Length_Of_Each_Word_Should_Return_ShortestWordLength_Arrow()
        {
            //Arrange
            var sentenceInput = "Njabulo is doing katas";
            var expected = 2;
            //Act
            var actual = _katas.FindShortArrowMethod(sentenceInput);
            //Asset
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Given_An_Array_When_FindingTheSumOfTwoNumbers_Should_Return_IndeciesOfTheTwoNumbers()
        {
            //Arrange
            var inputArray = new[] { 1, 2, 3 };
            var target = 4;
            var expected = new[] { 0, 2};
            //Act
            var actual = _katas.TwoSum(inputArray,target);
            //Asset
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Given_An_Array_When_FindingTheSumOfTwoNumbers_Should_Return_IndeciesOfTheTwoNumbers_2()
        {
            //Arrange
            var inputArray = new[] { 1, 2, 3 };
            var target = 4;
            var expected = new[] { 0, 2 };
            //Act
            var actual = _katas.TwoSum(inputArray, target);
            //Asset
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void Given_An_Array_When_FindingTheSumOfTwoNumbers_Should_Return_IndeciesOfTheTwoNumbers_3()
        {
            //Arrange
            var inputArray = new[] { 1234, 5678, 9012 };
            var target = 14690;
            var expected = new[] { 1, 2 };
            //Act
            var actual = _katas.TwoSum(inputArray, target);
            //Asset
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
