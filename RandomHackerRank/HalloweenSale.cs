using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomHackerRank
{
    public class HalloweenSale
    {
        public int CalculateTotalGames(int originalPrice, int priceDeduction, int thresholdPrice, int userAmount)
        {
            int gamePrice = originalPrice;
            int totalSpend = userAmount;
            int counter = 0;
            while (IsNotExceedingUserAmount(totalSpend, gamePrice))
            {
                totalSpend -= gamePrice;
                gamePrice = DeductPrice(gamePrice, priceDeduction);
                if (!NotReachedThreshold(gamePrice, thresholdPrice))
                {
                    priceDeduction = 0;
                    gamePrice = thresholdPrice;
                }
                counter++;
            }
            return counter;
        }

        private int DeductPrice(int salePrice, int deductableAmount) => salePrice - deductableAmount;
        private bool IsNotExceedingUserAmount(int totalSpend, int gamePrice) => totalSpend >= gamePrice;
        private bool NotReachedThreshold(int gamePrice, int thresholdPrice) => gamePrice >= thresholdPrice;
       
    }
}
