namespace WyCash
{
    public record Money
    {
        protected int _Amount;
        protected string _Currency;

        public Money(int amount, string currency)
        {
            _Amount = amount;
            _Currency = currency;
        }

        //// Definition of Equals and GetHashCode
        //public override bool Equals(object obj)
        //{
        //    if (obj == null || GetType() != obj.GetType())
        //    {
        //        return false;
        //    }

        //    Money money = (Money)obj;
        //    return _Amount == money._Amount && _Currency.Equals(money._Currency);
        //}

        //public override int GetHashCode()
        //{
        //    return base.GetHashCode();
        //}

        // Factory Methods for creating Dollar and Franc
        public static Money Dollar(int amount)
        {
            return new Money(amount, "USD");
        }

        public static Money Franc(int amount)
        {
            return new Money(amount, "CHF");
        }

        //public string Currency()
        //{
        //    return _Currency;
        //}

        public Money times(int multiplier)
        {
            return new Money(_Amount * multiplier, _Currency);
        }
    }
}
