internal partial class Program
{
    private static void Main(string[] args)
    {
         //Задача 47. Задайте двумерный массив размером m×n, 
        //заполненный случайными вещественными числами, округлёнными до одного знака.
        //    m = 3, n = 4.
        //   0,5 7 -2 -0,2
        //    1 -3,3 8 -9,9
        //    8 7,8 -7,1 9

        void zadacha47()
            {
                Random random = new Random();
                Console.Write("Введите количество строк: ");
                int rows = int.Parse(Console.ReadLine());
                Console.Write("Введите количество столбцов: ");
                int columns = int.Parse(Console.ReadLine());
                double[,] doubleArray = new double[rows, columns];
                Fillarray(doubleArray, rows,columns);
                PrintArray(doubleArray);

                double [,] Fillarray(double[,] array, int rows, int columns)
                {
                    for (int i=0; i<rows; i++)
                    {
                        for (int j=0; j< columns; j++)
                            {
                                array[i,j]=Math.Round(random.NextDouble()*10-5, 1);
                            }
                        
                    }
                    return array;
                }
                void PrintArray(double[,] array)
                {
                    for (int i=0; i<rows; i++)
                        {
                            for (int j=0; j< columns; j++)
                                {
                                    Console.Write(array[i,j] + "\t");
                                }
                                Console.WriteLine();
                    
                    }
                }
            }

            //Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
            //и возвращает значение этого элемента или же указание, что такого элемента нет.
            //Например, задан массив:
            //1 4 7 2
            //5 9 2 3
            //8 4 2 4
            //17 -> такого числа в массиве нет

            void zadacha50()
            {
                
                Random random = new Random();
                Console.Write("Введите количество строк: ");
                int rows = int.Parse(Console.ReadLine());
                Console.Write("Введите количество столбцов: ");
                int columns = int.Parse(Console.ReadLine());
                int[,] array = new int[rows, columns];
                Fillarray(array, rows,columns);
                PrintArray(array);
                Console.Write("Введите число для проверки нахождения его в массиве: ");
                int number = int.Parse(Console.ReadLine());
                findnumber(array);

                int [,] Fillarray(int[,] array, int rows, int columns)
                {
                    for (int i=0; i<rows; i++)
                    {
                        for (int j=0; j< columns; j++)
                            {
                                array[i,j]=random.Next(-99, 99);
                            }
                        
                    }
                    return array;
                }
                void PrintArray(int[,] array)
                {
                    for (int i=0; i<rows; i++)
                        {
                            for (int j=0; j< columns; j++)
                                {
                                    Console.Write(array[i,j] + "\t");
                                }
                                Console.WriteLine();
                    
                    }
                }
                void findnumber(int[,] array)
                {
                    
                    int count = 0;
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            if (array[i, j] == number)  count += 1;          
                        }
                    }
                Console.WriteLine($"Число {number} встречается в массиве {count} раз!");
                }
            
            }

        //Задача 52. Задайте двумерный массив из целых чисел. 
        //Найдите среднее арифметическое элементов в каждом столбце.
        //Например, задан массив:
        //1 4 7 2
        //5 9 2 3
        //8 4 2 4
        //Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
        void zadacha52()
        {
            Random random = new Random();
                Console.Write("Введите количество строк: ");
                int rows = int.Parse(Console.ReadLine());
                Console.Write("Введите количество столбцов: ");
                int columns = int.Parse(Console.ReadLine());
                int[,] array = new int[rows, columns];
                Fillarray(array, rows,columns);
                PrintArray(array);
                Console.WriteLine("Среднее арифметическое равно: ");
                MiddleArray(array);

                int[,] Fillarray(int[,] array, int rows, int columns)
                {
                    for (int i=0; i<rows; i++)
                    {
                        for (int j=0; j< columns; j++)
                            {
                                array[i,j]=random.Next(-99, 99);
                            }
                        
                    }
                    return array;
                }
                void PrintArray(int[,] array)
                {
                    for (int i=0; i<rows; i++)
                        {
                            for (int j=0; j< columns; j++)
                                {
                                    Console.Write(array[i,j] + "\t");
                                }
                                Console.WriteLine();
                    
                    }
                }
                void MiddleArray(int[,] array)
                {
                    double sum;
                    for (int i = 0; i < columns; i++)
                    {
                        sum = 0;
                        for (int j = 0; j < rows; j++)
                        {
                                sum += array[j, i];     
                        }
                        Console.WriteLine($"Столбец :{i + 1} равен {sum/rows}");
                    }
                }
        }
        zadacha47();
        zadacha50();
        zadacha52();
    }
}