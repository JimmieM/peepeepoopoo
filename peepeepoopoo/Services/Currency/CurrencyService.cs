using System;
using peepeepoopoo.Models.Player;

namespace peepeepoopoo.Services.Currency
{
    public class CurrencyService : Service
    {
        public CurrencyService(int userId) : base(userId)
        {
        }

        public void TakePlayerCurrency(Player player, Models.Currency.Currency currency)
        {
        }

        public void GivePlayerCurrency(Player player, Models.Currency.Currency currency)
        {
        }

        public void PlayerHasEnoughCurrency(Player player, Models.Currency.Currency currency)
        {
        }

        public void ValidateCurrency(Models.Currency.Currency currency)
        {
        }
    }
}
