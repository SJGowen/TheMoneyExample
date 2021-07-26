namespace WyCash
{
    public record Franc : Money
    {
        public Franc(int amount, string currency) : base(amount, currency)
        {
        }

        public override Money times(int multiplier)
        {
            return Money.franc(_Amount * multiplier);
        }
    }
}
