namespace WyCash
{
    public record Franc : Money
    {
        public Franc(int amount)
        {
            _Amount = amount;
            _Currency = "CHF";
        }

        public override Money times(int multiplier)
        {
            return new Franc(_Amount * multiplier);
        }
    }
}
