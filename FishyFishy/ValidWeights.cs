using System;
using System.Collections.Generic;

namespace FishMonger
{
    public class ValidWeights
    {
        private const int MAX_TOTAL_WEIGHT = 99;

        /// <summary>
        /// Get a list of valid weights for your drop down
        /// </summary>
        /// <param name="minWeight">The smallest cut of the fish</param>
        /// <param name="maxWeight">The biggest cut of the fish</param>
        /// <param name="increment">Increment between cuts</param>
        /// <returns>A list of valid combination weights</returns>
        public static List<int> getValidWeights(int minWeight, int maxWeight, int increment)
        {
            if (minWeight > maxWeight) throw new Exception("Why did you give me a minimum greater than the maximum? Were you taught common core math? Go home.");

            List<int> validWeights = new List<int>();

            if (minWeight == 0) return validWeights;

            List<int> weightAmounts = getWeightAmounts(minWeight, maxWeight, increment);

            validWeights = weightAmounts;

            for(int i = 0; i < weightAmounts.Count - 1; i++)
            {
                int multiplier = 2;

                while(weightAmounts[i] * multiplier < MAX_TOTAL_WEIGHT)
                {
                    validWeights.Add(weightAmounts[i] * multiplier);

                    multiplier += 1;
                }

                int i2 = i + 1;
                while(i2 < weightAmounts.Count)
                {
                    if(!validWeights.Contains(weightAmounts[i] + weightAmounts[i2])
                        && weightAmounts[i] + weightAmounts[i2] < MAX_TOTAL_WEIGHT)
                    {
                        validWeights.Add(weightAmounts[i] + weightAmounts[i2]);
                    }

                    i2++;
                }
            }

            /*
            int largestWeight = weightAmounts[weightAmounts.Count - 1];
            
            while(largestWeight < MAX_TOTAL_WEIGHT)
            {

            }
            */

            return validWeights;
        }

        private static List<int> getWeightAmounts(int minWeight, int maxWeight, int increment)
        {
            if (minWeight > maxWeight) throw new Exception("Stop.");

            List<int> weightAmounts = new List<int>();

            if (minWeight == 0) return weightAmounts;

            weightAmounts.Add(minWeight);

            int currentWeight = minWeight + increment;

            while(currentWeight <= maxWeight)
            {
                weightAmounts.Add(currentWeight);

                currentWeight += increment;
            }

            return weightAmounts;
        }
    }
}
