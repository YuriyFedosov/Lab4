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
            
            //определение переменных
            int valueA, valueB, valueC, valueX, valueY, valueS;
            //ввод ИД
            Console.WriteLine("Введи положительные числа A, B, C, где А и B стороны прямоугольника, C - размер стороны квадрата");
            Console.Write("Введите A: ");
            valueA= Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите B: ");
            valueB = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите C: ");
            valueC = Convert.ToInt32(Console.ReadLine());
            //Присвоение значений промежуточным переменных
            valueX = valueC;
            valueY = valueC;
            valueS = 0;
            //Подсчет квадратов в параметрах
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
            Console.WriteLine("Количество квадратов размещенных в прямоугольнике равно {0}", valueS);
            Console.ReadKey();
        }
    }
}
