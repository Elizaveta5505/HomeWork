// Написать программу, которая из имеющегося массива целых чисел формирует массив из чисел, больших 8. 
// Первоначальный массив можно ввести с клавиатуры, либо сгенерировать случайным образом.

int[] FillArray(int[] array)
{
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1, 20);
    }
    return array;
}

void PrintArray(int[] array)
{
    int size = array.Length;
    int position = 0;
    while (position < size)
    {
        Console.Write($"{array[position]} ");
        position++;
    }
}

int[] ChangeArray(int[] array)
{
    int N = 8;
    int[] mas2 = new int[array.Length];
    int j = 0;
    for (int i = 0; i < mas2.Length; i++)
    {
        if (array[i] > N)
        {
            mas2[j] = array[i];
            j++;
        }
    }
    return (mas2);
}

void PrintMas2(int[] mas2)
{
    int size = mas2.Length;
    for (int i = 0; i < size; i++)
    {
        if (mas2[i] != 0)
        {
            Console.Write($"{mas2[i]} ");
        }
    }
}

int[] array = new int[5];
FillArray(array);
PrintArray(array);
Console.Write($"-> ");
int[] mas2 = ChangeArray(array);
PrintMas2(mas2);
