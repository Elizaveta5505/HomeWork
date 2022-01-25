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
        if (array[position] != 0)
        {
            Console.Write($"{array[position]} ");
        }
        position++;
    }
}

int[] ChangeArray(int[] array)
{
    int N = 8;
    int[] mas2 = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > N)
        {
            mas2[i] = array[i];
        }
    }
    return mas2;
}

int[] array = new int[5];
FillArray(array);
PrintArray(array);
Console.Write($"-> ");
int[] mas2 = ChangeArray(array);
PrintArray(mas2);
