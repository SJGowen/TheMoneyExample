using System;

namespace WyCash
{
    public record Franc : Money
    {
        public Franc(int amount) : base(amount)
        {
        }

        public override Franc times(int multiplier)
        {
            return new Franc(Amount * multiplier);
        }
    }
}
