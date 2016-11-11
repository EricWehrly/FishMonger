using System.Collections.Generic;
using FishMonger;
using NUnit.Framework;

namespace FishMongerTests
{
    [TestFixture]
    public class ValidWeightsNuget
    {
        [Test]
        public void BigNumbersTest()
        {
            int maxWeight = 30;

            int minWeight = 26;

            int increment = 2;

            List<int> results = ValidWeights.getValidWeights(minWeight, maxWeight, increment);

            // Assert.AreEqual(12, results.Count);

            Assert.IsTrue(results.Contains(minWeight));

            Assert.IsTrue(results.Contains(28));

            Assert.IsTrue(results.Contains(maxWeight));

            Assert.IsTrue(results.Contains(26 + 26));

            Assert.IsTrue(results.Contains(26 + 30));

            Assert.IsTrue(results.Contains(28 + 30));

            Assert.IsTrue(results.Contains(30 + 30));

            Assert.IsTrue(results.Contains(26 + 26 + 26));

            Assert.IsTrue(results.Contains(26 + 26 + 28));

            Assert.IsTrue(results.Contains(26 + 26 + 30));

            Assert.IsTrue(results.Contains(26 + 28 + 28));

            Assert.IsTrue(results.Contains(26 + 28 + 30));

            Assert.IsTrue(results.Contains(28 + 28 + 28));

            Assert.IsTrue(results.Contains(28 + 30 + 30));

            Assert.IsTrue(results.Contains(30 + 30 + 30));
        }

        [Test]
        public void PowerOfTwo()
        {
            int minWeight = 4;

            int maxWeight = 8;

            int increment = 2;

            List<int> results = ValidWeights.getValidWeights(minWeight, maxWeight, increment);

            Assert.Contains(minWeight, results);

            Assert.Contains(maxWeight, results);

            Assert.Contains(minWeight + increment, results);

            // I'm not going to write every combination. Not right now.
            Assert.Contains(4 * 24, results);

            Assert.Contains(8 * 12, results);
        }

        [Test]
        public void PowerOfTwoNegativeTest()
        {
            int minWeight = 4;

            int maxWeight = 8;

            int increment = 2;

            List<int> results = ValidWeights.getValidWeights(minWeight, maxWeight, increment);

            Assert.IsFalse(results.Contains(0));

            Assert.IsFalse(results.Contains(4 * 25));

            Assert.IsFalse(results.Contains(8 * 13));

            // Actually, you know what ...

            foreach(int result in results)
            {
                Assert.IsTrue(result < 99);
            }
        }

        [Test]
        public void AssertNoDuplicates()
        {
            int minWeight = 4;

            int maxWeight = 8;

            int increment = 2;

            List<int> results = ValidWeights.getValidWeights(minWeight, maxWeight, increment);

            for(int i = 0; i < results.Count; i++)
            {
                for(int i2 = 1; i < results.Count; i++)
                {
                    if (i2 == i) continue;

                    Assert.AreNotEqual(results[i], results[i2]);
                }
            }

            /*

            foreach(int result in results)
            {
                for(int i = 0; i < results.Count - 1; i++)
                {
                    Assert.AreNotEqual(result, )
                }
            }
            */
        }
    }
}
