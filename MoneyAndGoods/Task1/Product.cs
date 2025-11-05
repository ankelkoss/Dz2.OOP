using System.Diagnostics;
using System.Drawing;

namespace MoneyAndGoods.Task1
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public Money Price { get; private set; } = new Money();

        public Product(int id, string name, Money price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public void IncreasePrice(long units, int coins)
        {
            var money = Counting(units, coins, true);

            Price.Units = money.Item1;
            Price.Coins = money.Item2;
        }

        public void DecreasePrice(long units, int coins)
        {
            var money = Counting(units, coins, false);

            Price.Units = money.Item1;
            Price.Coins = money.Item2;
        }

        private (long, int) Counting(long units, int coins, bool isAdd)
        {
            Check(units, coins);

            long current = ToTotalCoins(Price.Units, Price.Coins);
            long dif = ToTotalCoins(units, coins);

            long res = 0;

            if (isAdd)
            {
                 res = current + dif;
            }
            else
            {
                 res = current - dif;
            }

            return (res / 100L, (int)(res % 100));
        }

        private void Check(long units, int coins)
        {
            if (units < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(units), "Целая часть валюты не может быть отрицательной.");
            }
            else if (units > long.MaxValue)
            {
                throw new OverflowException($"У вас нет столько денег хД: {double.MaxValue}");
            }

            if (coins < 0 || coins > 99)
            {
                throw new ArgumentOutOfRangeException(nameof(coins), "Копейки должны быть в диапазоне 0..99.");
            }
        }

        private long ToTotalCoins(long units, int coins)
        {
            return units * 100L + coins;
        }

        public void PriceComparison(long units, int coins)
        {
            Check(units, coins);

            var money = new Money();
            money.SetMoney(this.Price.Currency, units, coins);

            Console.WriteLine($"Срввнение цен: {Price} и {money}");

            if (Price.Equals(money))
            {
                Console.WriteLine("Цены одинаковы");
            }
            else
            {
                Console.WriteLine("Цены НЕ одинаковы");
            }

            Console.WriteLine("");
        }
    }
}
