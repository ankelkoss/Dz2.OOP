
namespace MoneyAndGoods.Task2
{
    public abstract class MusicalInstrument
    {
        public string Name { get; protected set; } = string.Empty;
        public string Description { get; protected set; } = string.Empty;
        public string Histry { get; protected set; } = string.Empty; // название с ошибкой

        public virtual void Show() => Console.WriteLine($"Инструмент: {Name}");
        public virtual void Desc() => Console.WriteLine($"Описание: {Description}");
        public virtual void History() => Console.WriteLine($"История: {Histry}");

        public void DisplayAllInfo()
        {
            Console.WriteLine(new string('-', 40));
            Show();
            Desc();
            History();
            Console.WriteLine(new string('-', 40));
        }
    }
}
