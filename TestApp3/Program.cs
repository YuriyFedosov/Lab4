using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Часть №3
            Задачи на использование операторов цикла с предусловием. Осуществить ввод необходимых данных, 
            выполнить реализацию алгоритма с использованием операторов цикла while, обеспечить вывод полученных результатов. 
            Использование других операторов цикла недопустимо.
            Задачи 
            Ввести положительные числа A, B, C. На прямоугольнике размера A x B размещено максимально возможное количество 
            квадратов со стороной C (без наложений). Найти количество квадратов, размещенных на прямоугольнике. 
            Операции умножения и деления не использовать.*/

            int valueA, valueB, valueC, valueX, valueY, valueS;
            Console.WriteLine("A");
            valueA= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("B");
            valueB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("C");
            valueC = Convert.ToInt32(Console.ReadLine());
            
            valueX = valueC;
            valueY = valueC;
            valueS = 0;
            
            while (valueX<=valueA)
            {
                valueS++;
                valueX = valueX + valueC;
            }
            valueX = valueS;
            valueS = 0;
            while (valueY<=valueB)
            {
                valueS = valueS + valueX;
                valueY = valueY + valueC;
                               
            }
            Console.WriteLine("--->{0}", valueS);
            Console.ReadKey();
        }
    }
}
