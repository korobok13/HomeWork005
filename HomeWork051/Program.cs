// Задача 34: 
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


var array = FillArray(10);
Print(array);
System.Console.WriteLine();
var result = PlusNum(array);
System.Console.WriteLine("Четных чисел -> " +result);

int PlusNum(int[] array)
{
    int i = 0;
    int num = 0;
    while(i <= array.Length - 1)
    {
        if(array[i] % 2 == 0)
        {
            num = num + 1;            
        } 
        i++;
    }
    return num;
}

int[] FillArray(int length)
{
    int[] array = new int[length];
    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(99, 1000);
    }
    return array;
}

void Print(int[] array)
{
    foreach(var item in array)
    {
        Console.Write($"{item}, ");
    }
}

