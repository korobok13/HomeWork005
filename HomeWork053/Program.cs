// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

var array = FillArray(4);
Print(array);
double min = minNum(array);
double max = maxNum(array);
System.Console.WriteLine();
System.Console.WriteLine();
System.Console.WriteLine("Минимальное число ->" +(min));
System.Console.WriteLine("Максимальное число ->" +(max));
System.Console.WriteLine();
System.Console.WriteLine("Разница между максимальным и минимальным числом -> "+(max - min));


double minNum(double[] array)
{
    double min = array[0];
    int i = 0;
    while(i < array.Length)
    {
        if(array[i] <= min)
        {
            min = array[i];
        }
        i++;
    }

    return min;
}                            

double maxNum(double[] array)
{
    double max = array[0];
    int i = 0;
    while(i < array.Length)
    {
        if(array[i] >= max)
        {
            max = array[i];
        }
        i++;
    }

    return max;
}


double[] FillArray(int length)
{
    double[] array = new double[length];
    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().NextDouble()*(10);
    }
    return array;
}

void Print(double[] array)
{
    foreach(var item in array)
    {
        Console.Write($"{item}, ");
    }
}