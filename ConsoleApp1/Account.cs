using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_17
{
    class Account <T>
    {
        public T Number { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }

        public string GetInfo()
        {
            return $"{Number} {Balance} {Name}";
        }

        public void Input()
        {
            Console.WriteLine("Введите номер счета");
            Number = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));

            Console.WriteLine("Введите баланс");
            Balance = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите ФИО владельца счета");
            Name = Console.ReadLine();
        }
    }
}
