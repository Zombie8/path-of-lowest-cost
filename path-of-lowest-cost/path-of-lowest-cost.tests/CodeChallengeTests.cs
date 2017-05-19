using System;
using NUnit.Framework;

namespace path_of_lowest_cost.tests
{
    [TestFixture]
    public class CodeChallengeTests
    {
        [Test]
        public void Should_throw_ArgumentOutOfRangeException_with_invalid_column_parameter()
        {
            // arrange
            // nothing to do

            // act
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => new CodeChallenge(1, 3));

            // assert
            StringAssert.Contains("you must have at least 5 columns", ex.Message);
        }

        [Test]
        public void Should_throw_ArgumentOutOfRangeException_with_invalid_row_parameter()
        {
            // arrange
            // nothing to do

            // act
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => new CodeChallenge(0, -1));

            // assert
            StringAssert.Contains("you must have at least 1 row", ex.Message);
        }

        [TestFixture]
        internal class GetArray
        {
            [Test]
            public void Should_return_a_multi_dimensional_array()
            {
                // arrange
                var testArray = new int[1, 5];
                var sut = new CodeChallenge(1, 5);

                // act
                var result = sut.GetArray();

                // assert
                Assert.AreEqual(testArray, result);
            }
        }

        [TestFixture]
        internal class AddValueToArray
        {
            [Test]
            public void Should_throw_IndexOutOfRangeException_with_invalid_column_parameter()
            {
                // arrange
                var sut = new CodeChallenge(1, 5);

                // act
                var ex = Assert.Throws<IndexOutOfRangeException>(() => sut.AddValueToArray(-2, 1, 1));

                // assert
                StringAssert.Contains("column must not be a negative number", ex.Message);
            }

            [Test]
            public void Should_throw_IndexOutOfRangeException_with_invalid_row_parameter()
            {
                // arrange
                var sut = new CodeChallenge(1, 5);

                // act
                var ex = Assert.Throws<IndexOutOfRangeException>(() => sut.AddValueToArray(5, -1, 1));

                // assert
                StringAssert.Contains("row must not be a negative number", ex.Message);
            }

            [Test]
            public void Should_insert_positive_value_at_specified_array_location()
            {
                // arrange
                var testArray = new int[,] {
                    {0, 0, 0, 0, 5}
                };
                var sut = new CodeChallenge(1, 5);

                // act
                sut.AddValueToArray(0, 4, 5);
                var result = sut.GetArray();

                // assert
                Assert.AreEqual(testArray[0, 4], result[0, 4]);
            }

            [Test]
            public void Should_insert_negative_value_at_specified_array_location()
            {
                // arrange
                var testArray = new int[,] {
                    {0, 0, 0, 0, -5}
                };
                var sut = new CodeChallenge(1, 5);

                // act
                sut.AddValueToArray(0, 4, -5);
                var result = sut.GetArray();

                // assert
                Assert.AreEqual(testArray[0, 4], result[0, 4]);
            }
        }
    }
}