using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickSorter;

namespace QuickSorter.Test
{
    [TestClass]
    public class QuickSorterUnitTests
    {
        [TestMethod]
        public void TestThreeElements()
        {
            var rnd = new Random(40);
            var array = new int[3];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(100);
            }

            QuickSortClass.QuickSort(array);

            Assert.IsTrue(array[0] < array[1] && array[1] <= array[2]);
        }

        [TestMethod]
        public void Test100EqualsElements()
        {
            var array = new int[100];

            QuickSortClass.QuickSort(array);

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = 5;
            }

            for (int i = 0; i < array.Length; i++)
            {
                Assert.AreEqual(array[i], 5);
            }
        }

        [TestMethod]
        public void Test1000EqualsElements()
        {
            var rnd = new Random(40);
            var array = new int[1000];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(100);
            }

            QuickSortClass.QuickSort(array);

            for (int i = 0; i < array.Length; i++)
            {
                var x = rnd.Next(100);
                var y = rnd.Next(100);
                while (x < y)
                {
                    x = rnd.Next(100);
                    y = rnd.Next(100);
                }
                Assert.IsTrue(array[x] >= array[y]);
            }
        }

        [TestMethod]
        public void TestSortEmptyArray()
        {
            var array = new int[] { };

            QuickSortClass.QuickSort(array);
        }

        [TestMethod]
        public void Test1500000000Elements()
        {
            var rnd = new Random();
            var array = new int[1500000000];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(100);
            }

            QuickSortClass.QuickSort(array);

            for (int i = 0; i < array.Length - 1; i++)
            {
                Assert.IsTrue(array[i] <= array[i + 1]);
            }
        }
    }
}
