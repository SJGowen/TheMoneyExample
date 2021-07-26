using WyCash;
using Xunit;

namespace WyCashTests
{
    public class MoneyTests
    {
        [Fact]
        public void TestMultiplication()
        {
            Money fiveDollars = Money.Dollar(5);
            Assert.Equal(Money.Dollar(10), fiveDollars.times(2));
            Assert.Equal(Money.Dollar(15), fiveDollars.times(3));

            Money fiveFrancs = Money.Franc(5);
            Assert.Equal(Money.Franc(10), fiveFrancs.times(2));
            Assert.Equal(Money.Franc(15), fiveFrancs.times(3));
        }

        [Fact]
        public void TestEquality()
        {
            Assert.True(Money.Dollar(5).Equals(Money.Dollar(5)));
            Assert.False(Money.Dollar(5).Equals(Money.Dollar(6)));

            Assert.False(Money.Dollar(5).Equals(Money.Franc(5)));
        }

        [Fact]
        public void TestSimpleAddition()
        {
            Money sum = Money.Dollar(5).plus(Money.Dollar(5));
            Assert.Equal(Money.Dollar(10), sum);
        }
    }
}
