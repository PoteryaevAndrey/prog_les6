/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int[] Array(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите число {i + 1}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int Check(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] > 0) 
            result = result + 1;
        
    
    return result;
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = Array(size);

int result = Check(array);
ShowArray(array);
Console.WriteLine($"Итого {result} чисел больше 0");


