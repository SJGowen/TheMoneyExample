namespace WyCash
{
    public abstract record Money
    {
        protected int _Amount;
        protected string _Currency;

        public static Dollar dollar(int amount)
        {
            return new Dollar(amount, "USD");
        }

        public static Franc franc(int amount)
        {
            return new Franc(amount, "CHF");
        }

        public string Currency()
        {
            return _Currency;
        }

        public abstract Money times(int multiplier);
    }
}
