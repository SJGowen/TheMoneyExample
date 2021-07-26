namespace WyCash
{
    public record Franc : Money
    {
        public Franc(int amount, string currency)
        {
            _Amount = amount;
            _Currency = currency;
        }

        public override Money times(int multiplier)
        {
            return Money.franc(_Amount * multiplier);
        }
    }
}
