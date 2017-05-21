<<<<<<< HEAD
﻿using System;
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
=======
﻿using System;
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
                var ex = Assert.Throws<IndexOutOfRangeException>(() => sut.AddValueToArray(1, -2, 1));

                // assert
                StringAssert.Contains("column must not be a negative number", ex.Message);
            }

            [Test]
            public void Should_throw_IndexOutOfRangeException_with_invalid_row_parameter()
            {
                // arrange
                var sut = new CodeChallenge(1, 5);

                // act
                var ex = Assert.Throws<IndexOutOfRangeException>(() => sut.AddValueToArray(-1, 5, 1));

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

        [TestFixture]
        internal class GetLeastCost
>>>>>>> c52b2bd3c3dcd44d79254b74eec0b58a27714b9b
        {
            [Test]
            public void Should_return_upper_value()
            {
                // arrange
<<<<<<< HEAD
                var testArray = new int[1, 5];
=======
>>>>>>> c52b2bd3c3dcd44d79254b74eec0b58a27714b9b
                var sut = new CodeChallenge(1, 5);

                // act
                var result = sut.GetLeastCost(5, 10, 10);

                // assert
                Assert.AreEqual("upper", result);
            }

            [Test]
            public void Should_return_horizontal_value()
            {
                // arrange
                var sut = new CodeChallenge(1, 5);

                // act
                var result = sut.GetLeastCost(10, 5, 10);

                // assert
                Assert.AreEqual("horizontal", result);
            }

            [Test]
            public void Should_return_lower_value()
            {
                // arrange
                var sut = new CodeChallenge(1, 5);

                // act
                var result = sut.GetLeastCost(10, 10, 5);

                // assert
                Assert.AreEqual("lower", result);
            }
        }

        [TestFixture]
        internal class Solve2
        {
            [Test]
            public void Should_return_a_tuple_data_structure()
            {
                // arrange
<<<<<<< HEAD
                var testArray = new int[,] {
                    {0, 0, 0, 0, 5}
                };
                var sut = new CodeChallenge(1, 5);

                // act
                sut.AddValueToArray(0, 4, 5);
                var result = sut.GetArray();
=======
                var sut = new CodeChallenge(1, 5);

                // act
                var result = sut.Solve2();
>>>>>>> c52b2bd3c3dcd44d79254b74eec0b58a27714b9b

                // assert
                Assert.IsInstanceOf<Tuple<string, int, int[]>>(result);
            }

            [Test]
            public void Should_return_successful_outcome()
            {
                // arrange
<<<<<<< HEAD
                var testArray = new int[,] {
                    {0, 0, 0, 0, -5}
                };
                var sut = new CodeChallenge(1, 5);
=======
                var expectedresult = new Tuple<string, int, int[]>("Yes", 5, new int[] { 1, 1, 1, 1, 1 });

                var sut = new CodeChallenge(1, 5);
                sut.AddValueToArray(0, 0, 1);
                sut.AddValueToArray(0, 1, 1);
                sut.AddValueToArray(0, 2, 1);
                sut.AddValueToArray(0, 3, 1);
                sut.AddValueToArray(0, 4, 1);
>>>>>>> c52b2bd3c3dcd44d79254b74eec0b58a27714b9b

                // act
                var actualResult = sut.Solve2();

                // assert
                Assert.AreEqual(expectedresult, actualResult);

            }
        }
    }
}