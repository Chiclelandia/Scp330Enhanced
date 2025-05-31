using InventorySystem.Items.Usables.Scp330;
using Scp330Enhanced.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Scp330Enhanced
{
    public class RandomCandySelector
    {
        private Random _random = new Random();

        public CandyKindID GetRandomCandy(List<ConfigCandyitem> candies)
        {
            double totalWeight = candies.Sum(c => c.Weight);

            if (totalWeight <= 0)
                throw new InvalidOperationException("Total weight must be greater than zero. Missing candy list with weight?");

            double randomNumber = _random.NextDouble() * totalWeight;

            double cumulativeWeight = 0;

            foreach (var candy in candies)
            {
                cumulativeWeight += candy.Weight;
                if (randomNumber < cumulativeWeight)
                {
                    return candy.Candy;
                }
            }

            throw new InvalidOperationException("No candy selected. This should not happen if the weight is set correctly.");
        }
    }
}
