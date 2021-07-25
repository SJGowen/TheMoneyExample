using System;

namespace WyCash
{
    public record Franc
    {
        private int Amount;

        public Franc(int amount)
        {
            Amount = amount;
        }

        public Franc Times(int multiplier) => new(Amount * multiplier);
    }
}
