/*
 A 1 50 
 A 2 100 
 A 3 130
 
 B 1 30 
 B 2 45 
 B 3 75
 
 C 1 20 
 C 2 40 
 C 3 60
  
 */

using System.Collections.Generic;
using NUnit.Framework;

namespace CheckOutKata
{
    [TestFixture]
    public class TestCheckOut
    {

        [TestCase(1, 50, 3, 20, 0, 30, 2, 15,0,20,1,0, 50)]
        [TestCase(2, 50, 3, 20, 0, 30, 2, 15, 0, 20, 1, 0, 100)]
        [TestCase(3, 50, 3, 20, 0, 30, 2, 15, 0, 20, 1, 0, 130)]
        [TestCase(4, 50, 3, 20, 0, 30, 2, 15, 0, 20, 1, 0, 180)]
        [TestCase(5, 50, 3, 20, 0, 30, 2, 15, 0, 20, 1, 0, 230)]
        [TestCase(6, 50, 3, 20, 0, 30, 2, 15, 0, 20, 1, 0, 260)]
        [TestCase(6, 50, 3, 20, 1, 30, 2, 15, 0, 20, 1, 0, 290)]
        [TestCase(6, 50, 3, 20, 2, 30, 2, 15, 0, 20, 1, 0, 305)]
        [TestCase(6, 50, 3, 20, 3, 30, 2, 15, 0, 20, 1, 0, 335)]
        [TestCase(6, 50, 3, 20, 4, 30, 2, 15, 0, 20, 1, 0, 350)]
        [TestCase(6, 50, 3, 20, 4, 30, 2, 15, 1, 20, 1, 0, 370)]
        [TestCase(6, 50, 3, 20, 4, 30, 2, 15, 2, 20, 1, 0, 390)]
        [TestCase(6, 50, 3, 20, 4, 30, 2, 15, 3, 20, 1, 0, 410)]
        public void Given_CollectionItemThatContains_Number_Price_DiscountRule_DiscountValue_For_A_B_C_When_CalculateTotalPriceCalled_Then_Should_Return_ExpectedTotalPrice(int numberOfA, int priceOfA, int discountRuleForA, int discountValueForA, int numberOfB, int priceOfB, int discountRuleForB, int discountValueForB,int numberOfC,int priceOfC,int discountRuleForC,int discountValueForC, int expectedTotalPrice)
        {
            var checkOut = new CheckOut();
            var itemList=new Dictionary<Item, int>();
            itemList.Add(new Item {DiscountRule = discountRuleForA,DiscountValue = discountValueForA,Name = "A",Price = priceOfA},numberOfA );
            itemList.Add(new Item {DiscountRule = discountRuleForB,DiscountValue = discountValueForB,Name = "B",Price = priceOfB},numberOfB );
            itemList.Add(new Item {DiscountRule = discountRuleForC,DiscountValue = discountValueForC,Name = "C",Price = priceOfC},numberOfC );
            int totalPrice = checkOut.CalculateTotalPrice(itemList);
            Assert.That(totalPrice, Is.EqualTo(expectedTotalPrice));
        }
    }
}
