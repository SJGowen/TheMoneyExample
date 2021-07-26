using WyCash;
using Xunit;

namespace WyCashTests
{
    public class MoneyTests
    {
        [Fact]
        public void TestMultiplication()
        {
            Money fiveDollars = Money.dollar(5);
            Assert.Equal(Money.dollar(10), fiveDollars.times(2));
            Assert.Equal(Money.dollar(15), fiveDollars.times(3));

            Money fiveFrancs = Money.franc(5);
            Assert.Equal(Money.franc(10), fiveFrancs.times(2));
            Assert.Equal(Money.franc(15), fiveFrancs.times(3));
        }

        [Fact]
        public void TestEquality()
        {
            Assert.True(Money.dollar(5).Equals(Money.dollar(5)));
            Assert.False(Money.dollar(5).Equals(Money.dollar(6)));

            Assert.True(Money.franc(5).Equals(Money.franc(5)));
            Assert.False(Money.franc(5).Equals(Money.franc(6)));

            Assert.False(Money.dollar(5).Equals(Money.franc(5)));
        }
    }
}
