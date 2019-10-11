using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using MyUtils;
using MyUtils.Exceptions;

namespace TestNUnit
{
    [TestFixture]
    class TestColassVectorWithNUnit
    {
        [Test]
        public void TestConstructorWithLegalSize()
        {
            Vector v = new Vector(3);
            Assert.IsNotNull(v);
        }

        [Test]
        //[ExpectedException(typeof(IllegalArgumentException))]
        public void TestMethodConstructorWithNegativeLength()
        {
            //Assert.That(() => new Vector(-1), Throws<IllegalArgumentException>);
            Assert.Throws<IllegalArgumentException>(() => new Vector(-1));
        }

        [Test]
        public void TestMethodWithLegalSize()
        {
            Vector v = new Vector(4);
            Assert.IsNotNull(v);
        }

        [Test]
        public void TestLength()
        {
            int length = 5;
            Vector v = new Vector(length);
            Assert.AreEqual(v.Length, length);
        }

        [Test]
        //[ExpectedException(typeof(IllegalArgumentException))]
        public void TestConstructorNullContents()
        {
            Assert.Throws<IllegalArgumentException>(() => new Vector(null));
        }

        [Test]
        //[ExpectedException(typeof(IllegalArgumentException))]
        public void TestConstructorEmptyContents()
        {
            Assert.Throws<IllegalArgumentException>(() => new Vector(new double[] { }));
        }

        [Test]
        public void TestConstructorWithContents()
        {
            double[] contents = new double[] { 1, 2, 3.5 };
            Vector v = new Vector(contents);
            Assert.AreEqual(contents.Length, v.Length);
            for (int i = 0; i < v.Length; i++)
            {
                Assert.AreEqual(v[i], contents[i]);
            }
        }

        [Test]
        public void TestIndexer()
        {
            double[] contents = new double[] { 1, 2, 3.5 };
            Vector v = new Vector(contents.Length);
            Assert.AreEqual(contents.Length, v.Length);
            for (int i = 0; i < contents.Length; i++)
            {
                v[i] = contents[i];
            }
            for (int i = 0; i < v.Length; i++)
            {
                Assert.AreEqual(v[i], contents[i]);
            }
        }
    }
}
