using System;
using WyCash;
using Xunit;

namespace WyCashTests
{
    public class MoneyTests
    {
        [Fact]
        public void testMultiplication()
        {
            Dollar five = new Dollar(5);
            five.Times(2);
            Assert.Equal(10, five.Amount);
            five.Times(3);
            Assert.Equal(15, five.Amount);
        }
    }
}
