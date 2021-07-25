﻿using System;

namespace WyCash
{
    public record Dollar
    {
        public int Amount;

        public Dollar(int amount)
        {
            Amount = amount;
        }

        public Dollar Times(int multiplier) => new Dollar(Amount * multiplier);
    }
}
