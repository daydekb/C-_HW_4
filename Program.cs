// Задача №1:
// Напишите программу, которая бесконечно запрашивает целые числа с консоли. Программа завершается при вводе символа ‘q’ 
// или при вводе числа, сумма цифр которого чётная.
// 5 12 16 q [STOP]
// 3 45 342 15 [STOP]

string input = "";
    int num;
    bool exit = true;
    while (exit)
    {
        input = Input();
        if (int.TryParse(input, out num))
            exit = !(num % 2 == 0);
        else
        if (input == "q")
            exit = false;
    }
    string Input()
    {
        Console.WriteLine("Введите число или символ 'q' для выхода");
        return Console.ReadLine();
    }

// Задача №2:
// Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [344 452 341 125] => 2

// int[] CreateRandomArray(int size, int min, int max)
// {
//     int[] arr = new int[size];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(min, max);
//     }
//     return arr;
// }

// void PrintArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         System.Console.Write(arr[i] + " ");
//     }
//     System.Console.WriteLine();
// }


// int NuberOfNumbers (int[] arr)
// {
//     int count=0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] % 2 == 0)
//         {
//             count = count + 1;
//         }
//     }
//     return count;
// }

// Console.WriteLine("Input array size");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input maximal value");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] numbers = CreateRandomArray(size, min, max);
// Console.WriteLine(NuberOfNumbers(numbers));
// PrintArray(numbers);


// Задача №3
// Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)
// [1 3 5 6 7 8] => [8 7 6 5 3 1]

// int[] arr = { 1, 3, 5, 6, 7, 8, 4 };
// int stepEnd = 0;
// int step = 0;
// for (int i = 0; i <= (arr.Length-1) / 2; i++)
// {
//     step = arr[i];
//     arr[i] = arr[arr.Length - 1 - stepEnd];
//     arr[arr.Length - 1 - stepEnd] = step;
//     stepEnd += 1;
// }

// void PrintArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         System.Console.Write(arr[i] + " ");
//     }
//     System.Console.WriteLine();
// }

// PrintArray(arr);