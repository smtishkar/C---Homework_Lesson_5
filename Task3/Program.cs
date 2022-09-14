// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();
int [] FIllArray (int size, int minValue, int maxValue)
{
    int [] arr = new int [size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue+1);
    }
    return arr;
}

int [] array = FIllArray(5,0,20);


void GetDif (int [] collection)
{
int length = collection.Length;
int index = 0;
int difference = 0;
int min = collection[0];
int max = index;
    for (index = 0; index < length; index++)
    {
        if (collection[index] < min) 
        min = collection[index]; 
        if (collection[index] > max) 
        max = collection[index];
        
        difference = max - min;
    } 
    // Console.Write (min);
    // Console.Write (max);
    Console.Write ($"Разница между максимальным и минимальным элементом в массиве равняется {difference}");
    
}


void PrintArray (int [] myArray)
{
int length = myArray.Length;
int position = 0;

Console.Write ("[");
    for (position = 0; position < length-1; position++)
    {
        Console.Write ($"{myArray[position]}, ");
    }
    Console.Write ($"{myArray[position]}] ");
}

PrintArray(array);
GetDif(array);
