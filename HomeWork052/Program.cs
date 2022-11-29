// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


var array = FillArray(10);
Print(array);
int result = SumOddPosition(array);
System.Console.WriteLine();
System.Console.WriteLine("Сумма элементов нечетных позиций = " +result);

int SumOddPosition(int[] array)
{
    int i = 0;
    int sum = 0;
    while(i <= array.Length - 1)
    {
        if(i % 2 != 0)
        {
           sum = array[i] + sum;
        }
        i++;  
    }
       
    return sum;
}






int[] FillArray(int length)
{
    int[] array = new int[length];
    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(-10, 11);
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