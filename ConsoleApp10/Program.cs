using System;
using System.Threading;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Task1()
        {
            Console.WriteLine("Задание 1");
            Random rnd = new Random();
            int[] array = new int[14];
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(5, 101);
            }

            Console.WriteLine("Исходный массив: ");
            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0) count++;
            }

            Console.WriteLine($"Кол-во чётных элементов: {count}");

            Console.ReadKey();
        }

        static void Task2()
        {
            Console.WriteLine("Задание 2");

            Random rnd = new Random();
            int[] array_1 = new int[12];
            int[] array_2 = new int[12];
            int sum = 0, result;

            Console.WriteLine("Массив 1");

            for (int i = 0; i < array_1.Length; i++)
            {
                array_1[i] = rnd.Next(5, 101);
                Console.Write($"{array_1[i]} ");
            }

            Console.WriteLine("\nМассив 2");

            for (int i = 0; i < array_2.Length; i++)
            {
                array_2[i] = rnd.Next(5, 101);
                Console.Write($"{array_2[i]} ");
            }

            foreach (var item in array_1)
            {
                sum += item;
            }

            result = sum / array_1.Length;
            Console.WriteLine($"Среднее арифметическое всех значений массива 1: {result}");

            array_2.SetValue(result, 4);
            Console.WriteLine("Новый массив 2:");
            foreach (var item in array_2)
            {
                Console.Write($"{item}  ");
            }


            Console.ReadKey();
        }

        static void Task3()
        {
            Console.WriteLine("Задание 3");
            Random rnd = new Random();
            int[] array = new int[11];
            int sum = 0, count = 0, result;

            Console.WriteLine("Массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-50, 101);
                Console.Write($"{array[i]} ");
                sum += array[i];
            }

            result = sum / array.Length;

            Console.WriteLine($"\nСреднее арифметическое: {result}");

            foreach (var item in array)
            {
                if (Math.Abs(item) > result) count++;
            }

            Console.WriteLine($"\nОтвет: {count}");

            Console.ReadKey();
        }

        static void Task4()
        {
            Console.WriteLine("Задание 4");
            Random rnd = new Random();
            int[] array = new int[10];
            int max = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 101);
            }

            Console.WriteLine("Массив:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 101);
                Console.Write($"{array[i]} ");
            }

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[max])
                    max = i;
            }

            int temp = array[0];
            array[0] = array[max];
            array[(array.Length) - 1] = temp;

            Console.WriteLine($"\nИтоговый массив: ");
            foreach(var item in array)
            {
                Console.Write($"{item} ");
            }
            Console.ReadKey();
        }

        static void Task5()
        {
            Console.WriteLine("Задание 5");

            Random rnd = new Random();
            int[] array = new int[9];

            Console.WriteLine("Массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 101);
                Console.Write($"{array[i]} ");
            }

            int max = array[0], min = array[0];
            int max_index = 0, min_index = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    max_index = i;
                }
                if (array[i] < min)
                {
                    min = array[i];
                    min_index = i;
                }
            }

            int temp = array[max_index];
            array[max_index] = array[min_index];
            array[min_index] = temp;

            Console.WriteLine("\nИтоговый массив: ");
            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }

            Console.ReadKey();
        }

        static void Task6()
        {
            Console.WriteLine("Задание 6");

            Random rnd = new Random();
            int[] array = new int[20];
            int a = 0, b = 0;

            Console.WriteLine("Массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 101);
                Console.Write($"{array[i]} ");
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0) a++;
                else b++;
            }

            if (a > b)
            {
                Console.WriteLine("\nЧётных элементов больше");
            }
            else if (b > a)
            {
                Console.WriteLine("\nНечётных элементов больше");
            }
            else
            {
                Console.WriteLine("\nЧётных и нечётных элементов равное количество");
            }

            Console.ReadKey();
        }

        static void Task7()
        {
            Console.WriteLine("Задание 7");

            Random rnd = new Random();
            double[] array = new double[10];
            double a = array[0];
            int count = 0;

            Console.WriteLine("Массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.NextDouble() * 100;
                Console.Write($"{array[i]}  ");
            }
            
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > a) count++;
            }

            Console.WriteLine($"\nКоличество элементов больше первого: {count}");

            Console.ReadKey();
        }

        static void Task8()
        {
            Console.WriteLine("Задание 8");

            Random rnd = new Random();
            double[] array = new double[16];

            Console.WriteLine("Массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.NextDouble() * 100;
                Console.Write($"{array[i]} ");
            }
            int max_index = 0, min_index = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[max_index]) max_index = i;
                if (array[i] < array[min_index]) min_index = i;
            }

            Console.WriteLine($"\nРасположение(индекс) максимального элемента: {max_index}");
            Console.WriteLine($"Расположение(ндекс) минимального элемента: {min_index}");

            Console.ReadKey();
        }

        static void Task9()
        {
            Console.WriteLine("Задание 9");

            Random rnd = new Random();
            int[] array = new int[15];
            int[] result = new int[15];
            int sum = 0;

            Console.WriteLine("Массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 101);
                Console.Write($"{array[i]} ");
                sum += array[i];
            }

            int a = sum / array.Length;
            Console.WriteLine($"\nСреднее арифметическое: {a}");

            for (int i = 0; i < array.Length; i++)
            {
                result[i] = array[i] - a;
            }

            Console.WriteLine("Итоговый массив: ");
            foreach (var item in result)
            {
                Console.Write($"{item} ");
            }

            Console.ReadKey();
        }

        static void Task10()
        {
            Console.WriteLine("Задание 10");

            Random rnd = new Random();
            int[] array = new int[17];
            int sum_1 = 0, sum_2 = 0, count = 0, a;

            Console.WriteLine("Массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-50, 51);
                Console.Write($"{array[i]} ");
                if (array[i] < 0)
                {
                    sum_1 += Math.Abs(array[i]);
                    count++;
                }
            }

            a = count > 0 ? sum_1 / count : 0;
            Console.WriteLine($"\nСреднее арифметическое модулей отрицательных элементов: {a}");

            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[i]) > a)
                {
                    sum_2 += array[i];
                }
            }

            Console.WriteLine($"Сумма элементов, абсолютное значение которых больше среднего арифметического: {sum_2}");

            Console.ReadKey();
        }

        static void Task11()
        {
            Console.WriteLine("Задание 11");

            Random rnd = new Random();
            int[] array = new int[14];
            int count = 0, sum = 0;

            Console.WriteLine("Массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 101);
                Console.Write($"{array[i]} ");
            }


            foreach (var item in array)
            {
                if (item > 0 && item % 2 == 0)
                {
                    count++;
                    sum += item;
                }
            }

            Console.WriteLine($"\nКоличество чётных положительных элементов: {count}");
            Console.WriteLine($"Сумма чётных положительных элементов: {sum}");
            Console.ReadKey();
        }

        static void Task12()
        {
            Console.WriteLine("Задание 12");

            Random rnd = new Random();
            double[] array = new double[12];

            Console.WriteLine("Массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.NextDouble() * 100;
                Console.Write($"{array[i]} ");
            }

            Console.WriteLine();

            Array.Sort(array);
            Array.Reverse(array);

            Console.WriteLine("Отсортированный массив: ");
            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }

            double sum = array[0] + array[array.Length - 1];
            Console.WriteLine($"\nСумма максимального и минимального элементов: {sum}");

            Console.ReadKey();
        }

        static void Task13()
        {
            Console.WriteLine("Задание 13");

            Random rnd = new Random();
            int[] array = new int[12];

            Console.WriteLine("Массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 101);
                Console.Write($"{array[i]} ");
            }

            Console.WriteLine();

            Array.Sort(array);
            Array.Reverse(array);

            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }


            int sum = array[0] + array[array.Length - 1];
            int diff = array[0] - array[array.Length - 1];
            Console.WriteLine($"\nСумма максимального и минимального элементов: {sum}");
            Console.WriteLine($"Сумма максимального и минимального элементов: {diff}");

            Console.ReadKey();
        }

        static void Task14()
        {
            Console.WriteLine("Задание 14");

            Random rnd = new Random();
            int[] array = new int[17];
            int sum = 0;

            Console.WriteLine("Массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-50, 51);
                Console.Write($"{array[i]} ");
                if (array[i] % 2 != 0)
                {
                    sum += array[i];
                }
            }


            Console.WriteLine($"\nСумма нечётных элементов: {sum}");

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 3 == 0) array[i] = sum;
            }

            Console.WriteLine("Итоговый массив: ");
            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            while (true) 
            {
                Console.Clear();
                Console.Write("Выберите задание (1-14): ");
                switch (Console.ReadLine())
                {
                    case "1":
                        Task1();
                        break;

                    case "2":
                        Task2();
                        break;

                    case "3":
                        Task3();
                        break;

                    case "4":
                        Task4();
                        break;

                    case "5":
                        Task5();
                        break;

                    case "6":
                        Task6();
                        break;

                    case "7":
                        Task7();
                        break;

                    case "8":
                        Task8();
                        break;

                    case "9":
                        Task9();
                        break;

                    case "10":
                        Task10();
                        break;

                    case "11":
                        Task11();
                        break;

                    case "12":
                        Task12();
                        break;

                    case "13":
                        Task13();
                        break;

                    case "14":
                        Task14();
                        break;

                    default:
                        Console.WriteLine("Выберите корректный вариант!");
                        break;
                }
            }
        }
    }
}
