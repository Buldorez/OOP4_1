using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП_4_1
{
    class Health
    {
        public int Temp;
        public int Temperature
        {
            get
            {
                return Temp;
            }
            set
            {
                if (value < 34 || value > 41)
                    Console.WriteLine("Неверный ввод температуры");
                else
                    Console.WriteLine("Ваша температура = " + value);
            }
        }
        class Program
    {
            static void Main(string[] args)
            {
                Console.Write("Введите температуру больше 34 и менее 41: ");
                int NumTemp = Convert.ToInt32(Console.ReadLine());
                Health newTem = new Health();
                newTem.Temperature = NumTemp;
                Console.ReadLine(); 
            }
        }
}
}
