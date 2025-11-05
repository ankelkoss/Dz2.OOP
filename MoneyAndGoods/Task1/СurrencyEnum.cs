namespace MoneyAndGoods.Task1
{
    public enum CurrencyEnum
    {
        USD,
        EUR,
        UAH
    }

    public static class CurrencyEnumExtensions
    {
        public static string ToRu(this CurrencyEnum v) => v switch
        {
            CurrencyEnum.UAH => "Грн",
            CurrencyEnum.USD => "Доллар США",
            CurrencyEnum.EUR => "Евро",
            _ => v.ToString()
        };
    }
}
