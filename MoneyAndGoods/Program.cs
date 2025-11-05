using MoneyAndGoods.Task1;
using System.Text;

namespace MoneyAndGoods
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = new UTF8Encoding(false);
            Console.InputEncoding = new UTF8Encoding(false);
        }

        static void Task1()
        {
            (long, int) currentPrice = (10_299L, 87);
            (long, int) increasePrice = (100L, 56);
            (long, int) decreasePrice = (257L, 98);

            Money price = new Money();
            price.SetMoney(CurrencyEnum.UAH, currentPrice.Item1, currentPrice.Item2);

            Product product = new Product(23, "Beyerdynamic dt 990 pro", price);

            while (true)
            {
                try
                {
                    Console.WriteLine("\r\n");
                    Console.WriteLine($"Текущая цена {product.Price}");
                    Console.WriteLine($"1. Установить 10 000.00 грн цену товара '{product.Name}'.");
                    Console.WriteLine($"2. Увеличить цену на {increasePrice.Item1}.{increasePrice.Item2} {product.Price.Currency.ToRu()}");
                    Console.WriteLine($"3. Уменьшить цену на {decreasePrice.Item1}.{decreasePrice.Item2} {product.Price.Currency.ToRu()}");
                    Console.WriteLine($"4. Сравнить текущую цену с 1000.56 грн");
                    Console.WriteLine($"5. Выход");
                    Console.WriteLine("\r\nВыберите опцию: \r\n");

                    switch (Console.ReadKey(true).KeyChar.ToString())
                    {
                        case "1":
                            price.SetMoney(price.Currency, 10_000L, 00);
                            break;

                        case "2":
                            product.IncreasePrice(increasePrice.Item1, increasePrice.Item2);
                            break;

                        case "3":
                            product.DecreasePrice(decreasePrice.Item1, decreasePrice.Item2);
                            break;

                        case "4":
                            product.PriceComparison(1_000L, 56);
                            product.PriceComparison(currentPrice.Item1, currentPrice.Item2);
                            break;

                        case "5":
                            return;

                        default:
                            Console.WriteLine("Неверная опция");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex}");
                }

                Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}