namespace WyCash
{
    public record Dollar : Money
    {
        public Dollar(int amount, string currency)
        {
            _Amount = amount;
            _Currency = currency;
        }

        public override Money times(int multiplier)
        {
            return Money.dollar(_Amount * multiplier);
        }
    }
}
