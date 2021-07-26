namespace WyCash
{
    public record Dollar : Money
    {
        public Dollar(int amount)
        {
            _Amount = amount;
            _Currency = "USD";
        }

        public override Money times(int multiplier)
        {
            return new Dollar(_Amount * multiplier);
        }
    }
}
