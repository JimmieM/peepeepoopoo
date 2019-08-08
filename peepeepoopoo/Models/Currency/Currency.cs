using System;
using peepeepoopoo.Interfaces.Currency;

namespace peepeepoopoo.Models.Currency
{
    public class Currency : ICurrency
    {
        public const string CURRENCY = "BitFunds";

        public int Amount;
        public Currency(int amount)
        {
            Amount = amount;
        }
    }
}
