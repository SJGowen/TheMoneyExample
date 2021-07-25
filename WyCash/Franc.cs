using System;

namespace WyCash
{
    public record Franc : Money
    {
        public Franc(int amount) : base(amount)
        {
        }

        public Franc Times(int multiplier)
        {
            return new Franc(Amount * multiplier);
        }
    }
}
