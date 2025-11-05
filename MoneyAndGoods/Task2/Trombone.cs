using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyAndGoods.Task2
{
    public class Trombone : MusicalInstrument
    {
        public Trombone()
        {
            Name = "Тромбон";
            Description = "Медный духовой музыкальный инструмент с кулисным механизмом. \r\nОбладает мощным, ярким звуком.";
            Histry = "Тромбон произошел от сакбута в XV веке. \r\nШироко используется в симфонических и духовых оркестрах.";
        }

        public override void Show() => Console.WriteLine($"Инструмент: {Name}");
        public override void Desc() => Console.WriteLine($"Описание: {Description}");
        public override void History() => Console.WriteLine($"История: {Histry}");
    }
}
