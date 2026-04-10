//one pass time O(n), space O(1), brute force O(n2) every buysell pair is checked

//input prices = [7,1,5,3,6,4] output => 5
//two pointers time 0(n), space(0)1
//buy on day2 sell on day5
public class Solution2
{
    public int maxProfit(int[] prices)
    {
        int buyPrice = prices[0];
        int profit= 0;

        for (int i = 1; i < prices.Length; i++)
        {
            if(prices[i] < buyPrice)
            {
                 buyPrice = prices[i]; //lowest price, updating varaible if condition is met
            }
               
            else
            {
                int currentProfit = prices[i] - buyPrice;
                profit = Math.Max(currentProfit, profit);
            }
            
            
        }
            return profit;

    }
}