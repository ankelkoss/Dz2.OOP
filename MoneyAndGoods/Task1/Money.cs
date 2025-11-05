using System.Drawing;
using System.Globalization;

namespace MoneyAndGoods.Task1
{
    public class Money
    {
        //100    int
        //100L   long
        //100m   decimal
        //100.0  double
        //100f   float

        public CurrencyEnum Currency { get; private set; }
        private long TotalCoins { get; set; } = 0;

        public long Units
        {
            get => TotalCoins / 100;
            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Целая часть валюты не может быть отрицательной.");
                }
                else if(value > long.MaxValue)
                {
                    throw new OverflowException($"У вас нет столько денег хД: {double.MaxValue}");
                }
                else
                {
                    var coins = TotalCoins % 100;
                    TotalCoins = value * 100L + coins;
                }
            }
        }

        public int Coins
        {
            get
            {
                return (int)(TotalCoins % 100);
            }
            set 
            {
                if (value < 0 || value > 99)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Копейки должны быть в диапазоне 0..99.");
                }
                else
                {
                    var units = TotalCoins / 100;
                    TotalCoins = units * 100L + value;
                }
            }
        }

        public void SetMoney(CurrencyEnum currency, long units, int coins)
        {
            if (units < 0)
                throw new ArgumentOutOfRangeException(nameof(units), "Целая часть не может быть отрицательной.");
            if (coins < 0 || coins > 99)
                throw new ArgumentOutOfRangeException(nameof(coins), "Копейки должны быть в диапазоне 0..99.");

            Currency = currency;

            TotalCoins = units * 100L + coins;
        }

        private decimal AsDecimal => TotalCoins / 100m;

        public override string? ToString()
        {
            if(TotalCoins == 0)
            {
                return base.ToString();
            }

            var money = AsDecimal.ToString("F2", CultureInfo.InvariantCulture);
            return string.Format("{0} {1}", money.ToString(), Currency.ToRu());
        }

        public override int GetHashCode()
        {
            return TotalCoins.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if(obj is Money money)
            {
                return TotalCoins == money.TotalCoins;
            }

            return false;
        }
    }
}
