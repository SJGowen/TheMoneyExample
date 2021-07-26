namespace WyCash
{
    public record Dollar : Money
    {
        public Dollar(int amount, string currency) : base(amount, currency)
        {
        }

        public override Money times(int multiplier)
        {
            return Money.dollar(_Amount * multiplier);
        }
    }
}
