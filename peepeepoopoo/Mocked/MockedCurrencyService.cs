using System;
using peepeepoopoo.Interfaces.Currency;
using peepeepoopoo.Models.Player;
using peepeepoopoo.Services;

namespace peepeepoopoo.Mocked
{
    public class MockedCurrencyService : Service, ICurrencyService
    {
        public MockedCurrencyService(int userId) : base(userId) { }

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
