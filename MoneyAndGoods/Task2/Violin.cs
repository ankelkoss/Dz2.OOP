using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MoneyAndGoods.Task2
{
    public class Violin : MusicalInstrument
    {
        public Violin()
        {
            Name = "Скрипка";
            Description = "Струнный смычковый музыкальный инструмент с 4 струнами. \r\nИмеет высокий регистр и выразительный тембр.";
            Histry = "Скрипка появилась в XVI веке в Италии. \r\nСовременный вид приобрела в мастерских Амати, Страдивари и Гварнери.";
        }

        public override void Show() => Console.WriteLine($"Инструмент: {Name}");
        public override void Desc() => Console.WriteLine($"Описание: {Description}");
        public override void History() => Console.WriteLine($"История: {Histry}");
    }
}
