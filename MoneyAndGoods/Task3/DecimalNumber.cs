using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyAndGoods.Task3
{
    public struct DecimalNumber
    {
        private int _number;

        public int Number
        {
            get => _number;
            set => _number = value;
        }

        public DecimalNumber(int number)
        {
            _number = number;
        }

        public string ToBinary()
        {
            return Convert.ToString(_number, 2);
        }

        public string ToOctal()
        {
            return Convert.ToString(_number, 8);
        }

        public string ToHex()
        {
            return Convert.ToString(_number, 16).ToUpper();
        }

        public void DisplayCurrentNumber()
        {
            Console.WriteLine($"Текущее число: {_number}");
        }
    }
}
