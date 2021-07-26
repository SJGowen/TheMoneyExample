namespace WyCash
{
    public record Franc : Money
    {
        public Franc(int amount) : base(amount)
        {
        }

        public override Money times(int multiplier)
        {
            return new Franc(Amount * multiplier);
        }
    }
}
