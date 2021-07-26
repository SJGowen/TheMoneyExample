namespace WyCash
{
    public abstract record Money
    {
        protected int Amount;

        public Money(int amount)
        {
            Amount = amount;
        }

        public static Dollar dollar(int amount)
        {
            return new Dollar(amount);
        }

        public static Franc franc(int amount)
        {
            return new Franc(amount);
        }

        public abstract Money times(int multiplier);
    }
}
