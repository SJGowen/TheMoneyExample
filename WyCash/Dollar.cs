namespace WyCash
{
    public record Dollar : Money
    {
        public Dollar(int amount) : base(amount)
        {
        }

        public override Money times(int multiplier)
        {
            return new Dollar(Amount * multiplier);
        }
    }
}
