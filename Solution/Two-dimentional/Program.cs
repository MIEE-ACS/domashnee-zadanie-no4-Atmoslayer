//Вариант 18
using System;

namespace Two_dimentional
{
    class Program
    {
        static void Main(string[] args)
        {
            int row = 0;
            int col = 0;
            int counter = 0;
            int max = 0;
            int count = 0;
            int number = 0;

            while (true)
            {
                Console.Write("Введите количество строк:");
                string a = Console.ReadLine();

                if (!int.TryParse(a, out int n))
                {
                    Console.WriteLine("Проверьте вводимые данные");
                }

                if (int.TryParse(a, out int k))
                {
                    row = int.Parse(a);
                    if (row <= 0)
                    {
                        Console.WriteLine("Проверьте вводимые данные");
                    }
                    else
                    {
                        break;
                    }
                }
            }

            while (true)
            {
                Console.Write("Введите количество столбцов:");
                string a = Console.ReadLine();

                if (!int.TryParse(a, out int n))
                {
                    Console.WriteLine("Проверьте вводимые данные");
                }

                if (int.TryParse(a, out int k))
                {
                    col = int.Parse(a);
                    if (col <= 0)
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

            double[,] array = new double[row, col];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    array[i, j] = rndnum.NextDouble() *100 - 50;  //1000-7
                }
            }

            Console.WriteLine("Массив: ");

           
            
            for (int i = 0; i < row; i++)
               {
                   for (int j = 0; j < col; j++)
                   {
                       array[i,j] = Math.Round(array[i,j],3);
                       Console.Write(array[i,j] + "\t");
                   }
                   Console.WriteLine();
               }

            
            
            for (int i = 0; i < row; i++)
               {
                   for (int j = 0; j < col; j++)
                   {
                       array[i,j] = Math.Round(array[i,j],3);  //если подставить Truncate, будет больше нулей и одинаковых значний

                    if (array[i,j]==0)
                    {
                        counter++;
                        if (i != row-1) i++;
                    }
 
                   }
                  
               }
            Console.WriteLine($"Количество строк, где есть хотя бы один 0: {counter}");


            bool flag = false;
            for (int j = 0; j < col; j++)
            {
                for (int i = 0; i < row - 1; i++)
                {
                    if (array[i,j] == array[i+1,j])
                    {
                        if (flag)
                        {
                            count++;
                        }
                        else
                        {
                            flag = true;
                            count++;
                        }
                    }
                    else
                    {
                        if (flag)
                        {
                            if (count > max)
                            {
                                max = count;
                                number = j;
                            }
                        }
                        count = 0;
                        flag = false;
                    }
                }
            }
           
           

            Console.WriteLine($"Самая длинная серия одинаковых элементов в столбце {number}");

        }
    }
}
            
        
    

