using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyAndGoods.Task2
{
    public class Cello : MusicalInstrument
    {
        public Cello()
        {
            Name = "Виолончель";
            Description = "Струнный смычковый инструмент басового и тенорового регистра. \r\nИмеет богатый, глубокий тембр.";
            Histry = "Виолончель появилась в XVI веке.\r\nИзначально использовалась как басовый инструмент, позже стала сольным.";
        }

        public override void Show() => Console.WriteLine($"Инструмент: {Name}");
        public override void Desc() => Console.WriteLine($"Описание: {Description}");
        public override void History() => Console.WriteLine($"История: {Histry}");
    }
}
