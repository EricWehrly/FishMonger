using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using FishMonger;

namespace FishMongerTests
{
    [TestClass]
    public class ValidWeightsTests
    {
        [TestMethod]
        public void TestZeroInputs()
        {
            int maxWeight = 0;

            int minWeight = 0;

            int increment = 0;

            List<int> results = ValidWeights.getValidWeights(minWeight, maxWeight, increment);

            Assert.AreEqual(0, results.Count);
        }

        // [TestMethod]
        public void PowerOfTwo()
        {
            int maxWeight = 8;

            int minWeight = 4;

            int increment = 2;

            List<int> results = ValidWeights.getValidWeights(minWeight, maxWeight, increment);

            // Assert.AreEqual(3, results.Count);

            Assert.AreEqual(minWeight, results[0]);

            Assert.AreEqual(6, results[1]);

            Assert.AreEqual(maxWeight, results[2]);
        }

        // [TestMethod]
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
        
        public void old_BigNumbersTest()
        {
            int maxWeight = 30;

            int minWeight = 26;

            int increment = 2;

            List<int> results = ValidWeights.getValidWeights(minWeight, maxWeight, increment);

            // Assert.AreEqual(12, results.Count);

            Assert.AreEqual(minWeight, results[0]);

            Assert.AreEqual(28, results[1]);

            Assert.AreEqual(maxWeight, results[2]);

            Assert.AreEqual(26 + 28, results[3]);

            Assert.AreEqual(26 + 30, results[4]);

            Assert.AreEqual(28 + 30, results[5]);

            Assert.AreEqual(30 + 30, results[6]);

            Assert.AreEqual(26 + 26 + 26, results[7]);

            Assert.AreEqual(26 + 26 + 28, results[8]);

            Assert.AreEqual(26 + 26 + 30, results[9]);

            Assert.AreEqual(26 + 28 + 30, results[10]);

            Assert.AreEqual(26 + 30 + 30, results[11]);

            Assert.AreEqual(28 + 28 + 30, results[12]);

            Assert.AreEqual(28 + 30 + 30, results[13]);
        }
    }
}
