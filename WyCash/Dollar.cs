using System;

namespace WyCash
{
    public record Dollar : Money
    {
        public Dollar(int amount) : base(amount)
        {
        }

        public Dollar Times(int multiplier)
        {
            return new Dollar(Amount * multiplier);
        }
    }
}
