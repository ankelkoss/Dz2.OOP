using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MoneyAndGoods.Task2
{
    public class Ukulele : MusicalInstrument
    {
        public Ukulele()
        {
            Name = "Укулеле";
            Description = "Гавайский четырехструнный щипковый инструмент. \r\nНебольшого размера с мягким, жизнерадостным звучанием.";
            Histry = "Укулеле возник на Гавайских островах в XIX веке \r\nна основе португальских инструментов брагинья и кавакиньо.";
        }

        public override void Show() => Console.WriteLine($"Инструмент: {Name}");
        public override void Desc() => Console.WriteLine($"Описание: {Description}");
        public override void History() => Console.WriteLine($"История: {Histry}");
    }
}
