﻿using System;

namespace WyCash
{
    public class Dollar
    {
        public int Amount;

        public Dollar(int amount)
        {
            Amount = amount;
        }

        public Dollar Times(int multiplier)
        {
            return new Dollar(Amount * multiplier);
        }
    }
}
