// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
Console.Write("Вы хотели бы задать параметры массива вручную Y/N: ");
string initialRequest = Console.ReadLine();

while (initialRequest.ToLower() != "y" || initialRequest.ToLower() != "n")
{
    if (initialRequest.ToLower() == "y" || initialRequest.ToLower() == "n")
    {
        break;
    }
    else
    {
        Console.Write("Введите значение Y или N: ");
        initialRequest = Console.ReadLine();
    }

}

int elementsCount = 0;
int minValue = 0;
int maxValue = 0;

if (initialRequest.ToLower() == "y")
{
    Console.Write("Введите длину массива: ");
    elementsCount = int.Parse(Console.ReadLine());

    Console.Write("Введите минимальную границу ТРЁХЗНАЧНОЕ массива: ");
    minValue = int.Parse(Console.ReadLine());
    
    while (minValue < 100 || minValue > 999)
    {
        if (minValue < 100 || minValue > 999)
        {
            Console.Write("Введите минимальную границу ТРЁХЗНАЧНОЕ массива КОРРЕКТНО: ");
            minValue = int.Parse(Console.ReadLine());
        }
    }
    
    Console.Write("Введите максимальную границу ТРЁХЗНАЧНОГО массива: ");
    maxValue = int.Parse(Console.ReadLine());
    
    while (maxValue < 100 || maxValue > 999)
    {
        if (maxValue < 100 || maxValue > 999)
        {
            Console.Write("Введите максимальную границу ТРЁХЗНАЧНОЕ массива КОРРЕКТНО: ");
            maxValue = int.Parse(Console.ReadLine());
        }
    }

    while (minValue >= maxValue)
    {
        if (minValue >= maxValue)
        {
            Console.Write("Минимальная граница должна быть меньше максимальной, введите значения вновь. Начнем с минимальной границы: ");
            minValue = int.Parse(Console.ReadLine());

            while (minValue < 100 || minValue > 999)
            {   
                if (minValue < 100 || minValue > 999)
                {
                Console.Write("Введите минимальную границу ТРЁХЗНАЧНОЕ массива КОРРЕКТНО: ");
                minValue = int.Parse(Console.ReadLine());
                }
            }

            Console.Write("Введите максимальную границу ТРЁХЗНАЧНОЕ массива: ");
            maxValue = int.Parse(Console.ReadLine());

            while (maxValue < 100 || maxValue > 999)
            {
                if (maxValue < 100 || maxValue > 999)
                {
                Console.Write("Введите максимальную границу ТРЁХЗНАЧНОЕ массива КОРРЕКТНО: ");
                maxValue = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
else
{
    elementsCount = 10;
    minValue = 100;
    maxValue = 999;
}

int[] FillArray(int size, int minValue, int maxValue)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}

int[] array = FillArray(elementsCount, minValue, maxValue);


int CalculationInArray(int[] modarray)
{
    int length = modarray.Length;
    // int index = 0;
    int count = 0;
    for (int i = 0; i < length; i++)
    {
        if (modarray[i] % 2 == 0)
            count++;
        // Console.Write ($"{count}");
    }
    Console.Write($" в нем чётные числа встречаются {count} раз(а).");
    return count;
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
    Console.Write("],");
}

PrintArray(array);
CalculationInArray(array);


