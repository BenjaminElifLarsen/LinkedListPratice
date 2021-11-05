using LinkedList;
using System;
using System.Linq;
using Xunit;

namespace Test
{
    public class HashFiLoShould
    {
        [Fact]
        [Trait("Adding and Removing", "Int")]
        public void HandleInt()
        {
            HashFiLo<int> sut = new();
            Assert.Equal(0, sut.Count());
            sut.Add(5);
            Assert.Equal(1, sut.Count());
            sut.Add(2);
            sut.Add(3);
            sut.Add(2);
            Assert.Equal(3, sut.Count());
            sut.Remove();
            Assert.Equal(2, sut.Count());
        }
        [Fact]
        [Trait("Adding and Removing", "Int")]
        public void HandleIntBools()
        {
            HashFiLo<int> sut = new();
            sut.Add(5);
            bool result = sut.Add(5);
            Assert.Equal(1, sut.Count());
            Assert.False(result);
        }


        [Fact]
        [Trait("Adding and Removing", "String")]
        public void HandleString()
        {
            HashFiLo<string> sut = new();
            Assert.Equal(0, sut.Count());
            sut.Add(5.ToString());
            Assert.Equal(1, sut.Count());
            sut.Add(2.ToString());
            sut.Add(3.ToString());
            sut.Add(2.ToString());
            Assert.Equal(3, sut.Count());
            sut.Remove();
            Assert.Equal(2, sut.Count());
        }
    }

    public class FiLoShould
    {
        [Fact]
        [Trait("Adding and Removing", "Int")]
        public void HandleInt()
        {
            FiLo<int> sut = new();
            Assert.Equal(0, sut.Count());
            sut.Add(5);
            Assert.Equal(1, sut.Count());
            sut.Add(2);
            sut.Add(3);
            sut.Add(2);
            Assert.Equal(4, sut.Count());
            sut.Remove();
            Assert.Equal(3, sut.Count());
        }

        [Fact]
        [Trait("HandlingHead", "Int")]
        public void HandleNoHeadInt()
        {
            FiLo<int> sut = new();
            Assert.Equal(default,sut.GetValue());
        }

        [Fact]
        [Trait("HandlingHead", "Int")]
        public void HandleNeadInt()
        {
            FiLo<int> sut = new();
            sut.Add(5);
            Assert.Equal(5, sut.GetValue());
        }

        [Fact]
        [Trait("HandlingHead", "String")]
        public void HandleNoHeadString()
        {
            FiLo<string> sut = new();
            Assert.Equal(default, sut.GetValue());
        }

        [Fact]
        [Trait("HandlingHead", "String")]
        public void HandleHeadString()
        {
            FiLo<string> sut = new();
            sut.Add("Test");
            Assert.Equal("Test", sut.GetValue());
        }

        [Fact] //Theory
        [Trait("Sorting", "Int")]
        public void SortInt() //might be able to use theory in combination with params
        {
            var testValues = new int[] { 5, 2, 3, 2, 1, 2 ,0};
            FiLo<int> sut = new();

            foreach (var value in testValues)
                sut.Add(value);

            sut.Sort(sortSmall);
            Assert.Equal(testValues.Min(), sut.GetValue());

            sut.Sort(sortBig);
            Assert.Equal(testValues.Max(), sut.GetValue());

            bool sortSmall(int a, int b)
            {
                return a > b;
            }

            bool sortBig(int a, int b)
            {
                return a < b;
            }
        }

        [Fact]
        [Trait("Adding and Removing", "Float")]
        public void HandleFloat()
        {
            FiLo<float> sut = new();
            Assert.Equal(0, sut.Count());
            sut.Add(5.1f);
            Assert.Equal(1, sut.Count());
            sut.Add(2.5f);
            sut.Add(3f);
            sut.Add(2.1f);
            Assert.Equal(4, sut.Count());
            sut.Remove();
            Assert.Equal(3, sut.Count());
        }

        [Fact]
        [Trait("Sorting", "Float")]
        public void SortFloat()
        {
            var testValues = new float[] { 5.1f, 2.5f, 3f, 2.1f, 1.11f,10f};
            FiLo<float> sut = new();
            foreach (var value in testValues)
                sut.Add(value);

            sut.Sort(sortSmall);
            Assert.Equal(testValues.Min(), sut.GetValue());

            sut.Sort(sortBig);
            Assert.Equal(testValues.Max(), sut.GetValue());

            bool sortSmall(float a, float b)
            {
                return a > b;
            }

            bool sortBig(float a, float b)
            {
                return a < b;
            }
        }

    }
}
