// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] FillArray(int size, int minValue, int maxValue)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}

int[] array = FillArray(5, 0, 5);


int CalculationInArray(int[] modarray)
{
    int length = modarray.Length;
    int location = 0;
    int sum = 0;
    for (location = 0; location < length; location++)
    {
        if (location % 2 == 0)
        sum = sum + modarray[location];
    }
    Console.Write($" Cумма элементов стоящик на нечетных позициях равна {sum}");
    return sum;
}


void PrintArray(int[] collection)
{
    int lengh = collection.Length;
    int position = 0;
    Console.Write("Исходны массив [");
    while (position < lengh - 1)
    {
        Console.Write($"{collection[position]}, ");
        position++;
    }
    Console.Write($"{collection[position]}");
    Console.Write("] ->");
}

PrintArray(array);
CalculationInArray(array);
