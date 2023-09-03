/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

System.Console.Write("Введите количество чисел, которые планируете проверить_");
int sizeArray = int.Parse(Console.ReadLine());


int[] userArray = GenerateArray(sizeArray);
PrintArray(userArray);
CountMoreZero(userArray);


void CountMoreZero(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 0) result++;
    }
    System.Console.WriteLine();
    System.Console.WriteLine($"Количество положительных чисел равно: {result}");
}

void PrintArray(int[] array)
{
    foreach (int i in array)
    {
        Console.Write($"{i} ");
    }
}

int[] GenerateArray(int length)
{
    int[] result = new int[length];
    for (int i = 0; i < result.Length; i++)
    {
        System.Console.WriteLine($"Введите число {i+1}: ");
        result[i] = int.Parse(System.Console.ReadLine());
    }
    return result;
}