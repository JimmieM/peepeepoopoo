using System;
using peepeepoopoo.Interfaces.Currency;
using peepeepoopoo.Models.Player;

namespace peepeepoopoo.Services.Currency
{
    public class CurrencyService : Service, ICurrencyService
    {
        public CurrencyService(int userId) : base(userId) {}

        public void GivePlayerCurrency(Player player, Models.Currency.Currency newCurrency)
        {
            Player.Currency = newCurrency;
        }

        public bool PlayerHasEnoughCurrency(Player player, Models.Currency.Currency expectedCurrency)
        {
            return Player.Currency.Amount >= player.Currency.Amount;
        }

        public void TakePlayerCurrency(Player player, Models.Currency.Currency takeCurrency)
        {
            Player.Currency = takeCurrency;
        }
    }
}
