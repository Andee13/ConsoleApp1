using System;
namespace Arrays
{
    class Program
    {
        static void Main()
        {
            try
            {
                /*int[][] MyArray;
                Console.Write("Уведіть кількість рядків: ");
                int n = int.Parse(Console.ReadLine());
                MyArray = new int[n][];
                for (int i = 0; i < MyArray.Length; i++)
                {
                    Console.Write("введіть кількість елементів в {0} рядку: ", i);
                    int j = int.Parse(Console.ReadLine());
                    MyArray[i] = new int[j];
                    for (j = 0; j < MyArray[i].Length; j++)
                    {
                        Console.Write("a[{0}][{1}]= ", i, j);
                        MyArray[i][j] = int.Parse(Console.ReadLine());
                    }
                }
                PrintArray("вихідний масив:", MyArray);
                for (int i = 0; i < MyArray.Length; i++)
                    Array.Sort(MyArray[i]);
                PrintArray("змінений масив", MyArray);*/
                int[][] arr;
                arr = createArray();
                PrintArray("my array", arr);
            }
            catch (FormatException)
            {
                Console.WriteLine("невірний формат вводу даних");
            }
            catch (OverflowException)
            {
                Console.WriteLine("переповнення");
            }
            catch (OutOfMemoryException)
            {
                Console.WriteLine("недостатньо пам'яті для створення нового об'єкта");
            }
        }

        static int[][] createArray( )
        {
            int[][] arr;
            Console.Write("Уведіть кількість рядків: ");
            int n = int.Parse(Console.ReadLine());
            arr = new int[n][];
            int j = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                
                arr[i] = new int[j];
                for (j = 0; j < arr[i].Length; j++)
                {
                    Console.Write("a[{0}][{1}]= ", i, j);
                    arr[i][j] = int.Parse(Console.ReadLine());
                }

                j = (i+1) * 2;
            }

            return arr;

        }
        
        static void PrintArray(string a, int[][] mas)
        {
            Console.WriteLine(a);
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = 0; j < mas[i].Length; j++)
                    Console.Write("{0} ",
                        mas[i][j]);
                Console.WriteLine();
            }
        }
    }
}