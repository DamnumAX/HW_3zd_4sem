/*
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/

int [] CrArray()
{
    Console.WriteLine("Введите колличество элементов массива:");
    int elem = int.Parse(Console.ReadLine());
    int[] array = new int [elem];

    for (int a = 0; a< array.Length; a++)
    {
        Console.WriteLine($"ВВедите элемент массива под индексом {a}:");
        array[a] = int.Parse(Console.ReadLine());
    }

Console.WriteLine("[{0}]", string.Join(",",array));
return array;
}

int[] result = CrArray();
Console.WriteLine($"Создайте массив {result}:");