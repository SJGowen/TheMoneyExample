using System;

namespace WyCash
{
    public record Dollar : Money
    {
        public Dollar(int amount) : base(amount)
        {
        }

        public override Dollar times(int multiplier)
        {
            return new Dollar(Amount * multiplier);
        }
    }
}
