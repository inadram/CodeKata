using System.Collections.Generic;

namespace CheckOutKata
{
    public class CheckOut
    {
        public int CalculateTotalPrice(Dictionary<Item, int> itemList)
        {
            int totalPrice = 0;
            foreach (var item in itemList)
            {
                totalPrice += item.Value*item.Key.Price;
                totalPrice -= (item.Value/item.Key.DiscountRule)*item.Key.DiscountValue;
            }
            return totalPrice;
        }
    }
}