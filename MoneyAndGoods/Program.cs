using MoneyAndGoods.Task1;
using MoneyAndGoods.Task2;
using MoneyAndGoods.Task3;
using System.Text;

namespace MoneyAndGoods
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = new UTF8Encoding(false);
            Console.InputEncoding = new UTF8Encoding(false);

            //Task1();
            //Task2();
            Task3();
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

        static void Task2()
        {
            List<MusicalInstrument> musicalInstruments = new List<MusicalInstrument>
            {
                new Violin(),
                new Trombone(),
                new Ukulele(),
                new Cello()
            };

            while (true)
            {
                try
                {
                    Console.WriteLine("\r\n");
                    Console.WriteLine("===========================================");
                    Console.WriteLine("Демонстрация музыкальных инструментов");
                    Console.WriteLine("1. Скрипка");
                    Console.WriteLine("2. Тромбон");
                    Console.WriteLine("3. Укулеле");
                    Console.WriteLine("4. Виолончель");
                    Console.WriteLine("5. Показать все инструменты");
                    Console.WriteLine("6. Выход");
                    Console.WriteLine("Выберите инструмент: ");
                    Console.WriteLine("\r\n");

                    string key = Console.ReadKey(true).KeyChar.ToString();

                    var answer = Int(key);
                    if (answer.Item1 == true && (answer.Item2 >= 1 && answer.Item2 <= 4))
                    {
                        Console.Clear();
                        musicalInstruments[(answer.Item2 - 1)].DisplayAllInfo();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }

                Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                Console.ReadKey();
                Console.Clear();
            }

            //
            (bool, int) Int(string d)
            {
                int res = 0;
                bool isDone = false;

                try
                {
                    if (d == "5")
                    {
                        ShowAllInstruments();
                        isDone = false;
                    }
                    else if (d == "6")
                    {
                        Console.Clear();
                        Console.WriteLine("До свидания!");
                        Environment.Exit(0);
                    }
                    else
                    {
                        res = int.Parse(d);
                        isDone = true;
                    }
                }
                catch
                {
                    // doesn't matter
                    // isDone = false
                    // something error
                }

                return (isDone, res);
            }

            //
            void ShowAllInstruments()
            {
                Console.Clear();
                Console.WriteLine("\n" + new string('=', 50));
                Console.WriteLine("ВСЕ МУЗЫКАЛЬНЫЕ ИНСТРУМЕНТЫ");
                Console.WriteLine(new string('=', 50));

                foreach (var instrument in musicalInstruments)
                {
                    instrument.DisplayAllInfo();
                    Console.WriteLine();
                }
            }
        }

        static void Task3()
        {
            DecimalNumber decimalNumber = new DecimalNumber(0);

            while (true)
            {
                try
                {
                    Console.WriteLine("=================================");
                    Console.WriteLine($"Установленное число: {decimalNumber.Number}\r\n");
                    Console.WriteLine("1. Установить число");
                    Console.WriteLine("2. Превратить в двоичную систему");
                    Console.WriteLine("3. Превратить в восьмеричную систему");
                    Console.WriteLine("4. Превратить в шестнадцатеричную систему");
                    Console.WriteLine("5. Показать все преобразования");
                    Console.WriteLine("6. Выйти");
                    Console.WriteLine("Выберите опцию: \r\n");

                    switch (Console.ReadKey(true).KeyChar.ToString())
                    {
                        case "1":
                            SetNumber(ref decimalNumber);
                            break;
                        case "2":
                            ShowBinary(decimalNumber);
                            break;
                        case "3":
                            ShowOctal(decimalNumber);
                            break;
                        case "4":
                            ShowHex(decimalNumber);
                            break;
                        case "5":
                            ShowAllConversions(decimalNumber);
                            break;
                        case "6":
                            Console.WriteLine("До свидания!");
                            return;
                        default:
                            Console.WriteLine("Неправильный выбор!");
                            break;
                    }

                    Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                    Console.ReadKey();
                    Console.Clear();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex}");
                }
            }

            static void SetNumber(ref DecimalNumber decimalNumber)
            {
                Console.WriteLine("Введите целое число: ");
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    decimalNumber = new DecimalNumber(number);
                    Console.WriteLine($"Число установлено: {number}");
                }
                else
                {
                    Console.WriteLine("Ошибка: введите корректное число!");
                }
            }

            void ShowBinary(DecimalNumber decimalNumber)
            {
                Console.WriteLine($"Двоичное: {decimalNumber.Number} = {decimalNumber.ToBinary()}");
            }

            void ShowOctal(DecimalNumber decimalNumber)
            {
                Console.WriteLine($"Восьмеричное: {decimalNumber.Number} = {decimalNumber.ToOctal()}");
            }

            void ShowHex(DecimalNumber decimalNumber)
            {
                Console.WriteLine($"Шестнадцатеричное: {decimalNumber.Number} = {decimalNumber.ToHex()}");
            }

            void ShowAllConversions(DecimalNumber decimalNumber)
            {
                Console.WriteLine("Все вместе");
                ShowBinary(decimalNumber);
                ShowOctal(decimalNumber);
                ShowHex(decimalNumber);
            }
        }
    }
}