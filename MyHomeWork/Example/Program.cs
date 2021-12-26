// Написать программу, которая из имеющегося массива целых чисел формирует массив из чисел, больших 8. Первоначальный массив можно ввести с клавиатуры, либо сгенерировать случайным образом.
void FillArray(int[] array)
{
    int size = array.Length;
    int index = 0;
    while (index < size)
    {
        array[index] = new Random().Next(1, 20);
        index++;
    }
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

void ChangeArray(int[] array)
{
    int N = 8;
    int[] mas2 = new int[array.Length];
    for (int i = 0; i < mas2.Length; i++)
    {
        mas2[i] = array[i];
        if (mas2[i] > N)
        {
            Console.Write($"{mas2[i]} ");
        }
    }
}

int[] array = new int[5];
FillArray(array);
PrintArray(array);
Console.Write($"-> ");
ChangeArray(array);
