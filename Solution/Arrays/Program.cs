//Вариант 18
using System;

namespace Arrays
{
    class Program
    {


        static void Main(string[] args)
        {

            int length = 0;
            int C = 0;
            int Count = 0;
            double Sum = 0;
            int Minus = 0;
            double Max = 0;
            double Calculation = 0;
            


            while (true)
            {
                Console.Write("Введите размер массива:");
                string a = Console.ReadLine();

                if (!int.TryParse(a, out int n))
                {
                    Console.WriteLine("Проверьте вводимые данные");
                }

                if (int.TryParse(a, out int k))
                {
                    length = int.Parse(a);
                    if (length <=0)
                    {
                       Console.WriteLine("Проверьте вводимые данные");
                    }
                else
                    {
                        break;
                    }
                }
            }


            Random rndnum = new Random(DateTime.Now.Millisecond);

            double[] array = new double[length];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rndnum.NextDouble() * 100 - 50;
            }

            Console.WriteLine("Массив: ");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Math.Round(array[i], 3);
                Console.WriteLine(array[i]);
            }

            while (true)
            {
                Console.Write("Пора искать элемент, меньше, чем C, введите C: ");
                string b = Console.ReadLine();
               

                if (!int.TryParse(b, out int m))
                {
                    Console.WriteLine("Проверьте вводимые данные");
                }
                
                
                else
                {
                    C = int.Parse(b);
                    break;
                }
            }


            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < C)
                {
                    Count++;
                }

            }
            Console.WriteLine($"Количество элементов, меньше, чем C: {Count} ");


            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    Minus = i;
                }
            }
            for (int j = Minus + 1; j < array.Length; j++)
            {
                Sum += Math.Truncate(array[j]);
            }

            Console.WriteLine($"Сумма целых частей элементов после последнего отрицательного элемента: {Sum}");

            Max = array[1];
            for (int i=0; i<length; i++)
            {
                if (array[i]>Max)
                {
                    Max = array[i];
                }

            }
            Calculation = Max * 0.2;
            Calculation = Max - Calculation;

            int s = 0;
            int u = array.Length - 1;

            while (s<u)
            {
                if (array[s] > Calculation) s++;
                else if (array[u] > Calculation)
                {
                    var t = array[s];
                    array[s++] = array[u];
                    array[u] = t;
                }
                else u--;
            }



            Console.WriteLine("Отсортированный массив:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Math.Round(array[i], 3);
                Console.WriteLine(array[i]);
            }
        }


    }
}


