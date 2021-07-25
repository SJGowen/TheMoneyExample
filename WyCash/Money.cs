namespace WyCash
{
    public record Money
    {
        protected int Amount;

        public Money(int amount)
        {
            Amount = amount;
        }

        //public Money Times(int multiplier) => new(Amount * multiplier);
    }
}
