using System;
using peepeepoopoo.Models.Player;

namespace peepeepoopoo.Interfaces.Currency
{
    public interface ICurrencyService
    {
        void TakePlayerCurrency(Player player, Models.Currency.Currency takeCurrency);
        void GivePlayerCurrency(Player player, Models.Currency.Currency newCurrency);
        bool PlayerHasEnoughCurrency(Player player, Models.Currency.Currency expectedCurrency);
    }
}
