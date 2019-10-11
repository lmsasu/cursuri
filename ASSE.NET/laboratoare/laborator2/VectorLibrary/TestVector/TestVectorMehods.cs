using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VectorLibrary;
using VectorLibrary.Exceptions;
using System.Diagnostics.CodeAnalysis;

namespace TestVector
{
    /// <summary>
    /// Unit testing for vector class
    /// </summary>
    [ExcludeFromCodeCoverage]
    [TestClass]
    public class TestVectorMehods
    {
        /// <summary>
        /// Tests the default constructor.
        /// </summary>
        [TestMethod]
        public void TestConstructorWithLength()
        {
            int length = 10;
            Vector v = new Vector(length);
            Assert.IsNotNull(v);
            Assert.AreEqual(v.Length, length);
        }

        /// <summary>
        /// Tests the Vector constructor with zero length.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestConstructorZeroLength()
        {
            int length = 0;
            Vector v = new Vector(length);
        }

        /// <summary>
        /// Tests Vector constructor with negative length.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestConstructorNegativeLength()
        {
            int length = -1;
            Vector v = new Vector(length);
        }

        /// <summary>
        /// Tests the Vector constructor with contents.
        /// </summary>
        [TestMethod]
        public void TestConstructorWithContents()
        {
            double[] contents = { 1, 2, 3 };
            Vector v = new Vector(contents);
            Assert.AreEqual(v.Length, contents.Length);
            for(int i=0; i<v.Length; i++)
            {
                Assert.AreEqual(v[i], contents[i]);
            }
        }

        /// <summary>
        /// Tests the Vector constructor with null contents.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(NullContentsException))]
        public void TestConstructorWithNullContents()
        {
            double[] contents = null ;
            Vector v = new Vector(contents);
        }

        /// <summary>
        /// Tests the Vector constructor with empty contents.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(EmptyContentsException))]
        public void TestConstructorWithEmptyContents()
        {
            double[] contents = {};
            Vector v = new Vector(contents);
        }

        /// <summary>
        /// Tests the sum of two vectors.
        /// </summary>
        [TestMethod]
        public void TestSumVectors()
        {
            double[] v1 = { 1, 2, 3 };
            double[] v2 = { 3, 4, 5 };
            Vector vector1 = new Vector(v1);
            Vector vector2 = new Vector(v2);
            Vector sum = vector1 + vector2;
            Assert.IsNotNull(sum);
            Assert.AreEqual(sum.Length, v1.Length);
            for(int i=0; i<sum.Length; i++)
            {
                Assert.AreEqual(sum[i], v1[i] + v2[i]);
            }
        }

        /// <summary>
        /// Tests the sum of two vectors with null LHS.
        /// </summary>
        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void TestSumVectorsWithLeftNull()
        {
            double[] v1 = { 1, 2, 3 };
            Vector vector1 = new Vector(v1);
            Vector vector2 = null;
            Vector sum = vector1 + vector2;
        }

        /// <summary>
        /// Tests the sum of two vectors with null RHS.
        /// </summary>
        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void TestSumVectorsWithRightNull()
        {
            double[] v1 = { 1, 2, 3 };
            Vector vector1 = null;
            Vector vector2 = new Vector(v1);
            Vector sum = vector1 + vector2;
        }

        /// <summary>
        /// Tests the sum of two vectors with different lengths.
        /// </summary>
        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void TestSumVectorsWithDifferentLengths()
        {
            double[] v1 = { 1, 2, 3 };
            double[] v2 = { 1, 2, 3, 4 };
            Vector vector1 = new Vector(v1);
            Vector vector2 = new Vector(v2);
            Vector sum = vector1 + vector2;
        }
    }
}
