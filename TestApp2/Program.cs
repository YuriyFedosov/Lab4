using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Часть №2

            Задачи на использование операторов цикла с постусловием. Осуществить ввод необходимых данных, 
            выполнить реализацию алгоритма с использованием операторов цикла do - while, обеспечить вывод полученных результатов. 
            Использование других операторов цикла недопустимо.
            Задачи
            Осуществить ввод последовательности целых чисел и сравнить, что больше, количество положительных или количество отрицательных.
            Последовательность потенциально не ограничена, окончанием последовательности служит число 0.*/

            Console.WriteLine("Программа подсчета количества введенных целых чисел.");
           
            int inputNumber, sumPlusvalue = 0, sumMinusvalue = 0; //Инициализация переменных для расчетов

            do
            {
                Console.Write("Введите положительное или отрицательное целое число, введение нуля прекращает подсчет: ");
                inputNumber = Convert.ToInt32(Console.ReadLine());
                if (inputNumber>0) // Увеличение счетчика положительных значений
                {
                    sumPlusvalue++;
                }
                if (inputNumber < 0)// Увеличение счетчика отрицательных значений
                {
                    sumMinusvalue++;
                }


            } while (inputNumber != 0);

            //Подсчет разницы и вывод результата сравнения на экран

            if (sumPlusvalue > sumMinusvalue) 
            {
                inputNumber =  sumPlusvalue - sumMinusvalue;
                Console.WriteLine("Количество введенных положительных значений больше на {0}", inputNumber);
                
            }
            if (sumPlusvalue < sumMinusvalue)
            {
                inputNumber = sumMinusvalue - sumPlusvalue;
                Console.WriteLine("Количество введенных отрицательных значений больше на {0}", inputNumber);

            }
            if (sumMinusvalue == sumPlusvalue)
            {
                Console.WriteLine("Количество введенных положительных значений равно отрицательным");
            }

            Console.ReadKey();
        }
    }
}
