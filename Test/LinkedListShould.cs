using LinkedList;
using System;
using System.Linq;
using Xunit;

namespace Test
{
    public class LinkedListShould
    {
        [Fact]
        public void HandleInt()
        {
            LinkedList<int> sut = new();
            Assert.Equal(0, sut.Count());
            sut.AddFirst(5);
            Assert.Equal(1, sut.Count());
            sut.AddFirst(2);
            sut.AddFirst(3);
            sut.AddFirst(2);
            Assert.Equal(4, sut.Count());
            sut.RemoveFirst();
            Assert.Equal(3, sut.Count());

        }

        [Fact]
        public void SortInt()
        {
            var testValues = new int[] { 5, 2, 3, 2, 1, 2 ,0};
            LinkedList<int> sut = new();

            foreach (var value in testValues)
                sut.AddFirst(value);

            sut.Sort(sortSmall);
            Assert.Equal(testValues.Min(), sut.GetFirstValue());

            sut.Sort(sortBig);
            Assert.Equal(testValues.Max(), sut.GetFirstValue());

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
        public void HandleFloat()
        {
            LinkedList<float> sut = new();
            Assert.Equal(0, sut.Count());
            sut.AddFirst(5.1f);
            Assert.Equal(1, sut.Count());
            sut.AddFirst(2.5f);
            sut.AddFirst(3f);
            sut.AddFirst(2.1f);
            Assert.Equal(4, sut.Count());
            sut.RemoveFirst();
            Assert.Equal(3, sut.Count());

        }

        [Fact]
        public void SortFloat()
        {
            var testValues = new float[] { 5.1f, 2.5f, 3f, 2.1f, 1.11f,10f};
            LinkedList<float> sut = new();
            foreach (var value in testValues)
                sut.AddFirst(value);

            sut.Sort(sortSmall);
            Assert.Equal(testValues.Min(), sut.GetFirstValue());

            sut.Sort(sortBig);
            Assert.Equal(testValues.Max(), sut.GetFirstValue());

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
