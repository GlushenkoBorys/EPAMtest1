using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAMtest1
{// 1 - вводится начало диапазона и конец-нужно что-бы программа посчитала сколько будет чисел,
 //     в которых есть цифра 7. Пример: начало 10 конец 30 (2 числа с 7-кой )
   
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число начало диапазона");
            int startDiapason = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите число конца диапазона");
            int stopDiapason = Int32.Parse(Console.ReadLine());
            int diapason = stopDiapason - startDiapason;

            int[] array = new int[++diapason];

            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = startDiapason ++;
                char[] allChar = array[i].ToString().ToCharArray();
                
                char myChar;
                for (int y = 0; y < allChar.Length; y++)
                {
                    myChar = allChar[y];
                    if (myChar == '7')
                        sum++;
                }
            }
            Console.WriteLine($"Количество 7 в заданном диапазоне = {sum}"); 
            Console.ReadLine();
        }
    }
}
