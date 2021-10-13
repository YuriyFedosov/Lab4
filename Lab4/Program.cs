using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Часть №1 Задачи на использование операторов цикла for. Осуществить ввод необходимых данных, 
             * выполнить реализацию алгоритма с использованием операторов цикла for, обеспечить вывод полученных результатов. 
             * Не разрешается использовать другие операторы цикла.
             * Задачи: Ввести целое число N > 0. Найти квадрат данного числа, используя для его вычисления следующую формулу: 
             * N2=1 + 3 + 5 + ... + (2*N – 1). После добавления к сумме каждого слагаемого выводить текущее значение суммы 
             * (в результате будут выведены квадраты всех целых чисел от 1 до N).*/

            Console.Write("Программа вычисления квадрата введенного числа. Введите целое число для вычисления: ");

            int inputNumber = Convert.ToInt32(Console.ReadLine());
            int sumTotal = 0;

            for (int i = 1; i <= inputNumber; i++)
            {
                sumTotal = sumTotal + (i * 2 - 1);
                Console.WriteLine(sumTotal);

            }

            Console.WriteLine("Итого квадрат введенного числа {0} равен {1}", inputNumber, sumTotal);
            Console.ReadKey();
        }
    }
}
