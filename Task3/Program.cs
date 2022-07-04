//Задача 3: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.


double[] GenerateArray()
{
    System.Console.Write("Введите количество элементов массива > ");
    int length = Convert.ToInt32(Console.ReadLine());

    double[] newArray = new double[length];

    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = Convert.ToDouble(new Random().Next(-100, 100))/10;
    }
    return newArray;
}

void PrintArray(double[] array)
{
    System.Console.Write('[');
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($" {array[i]} ");
    }
    System.Console.Write(']');
}

double MaxMean(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (max < array[i]) max = array[i];
    }
    return max;
}

double MinMean(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i]) min = array[i];
    }
    return min;
}


double[] array = GenerateArray();
System.Console.Write("Полученный массив : ");
PrintArray(array);

double diff = MaxMean(array) - MinMean(array);
System.Console.WriteLine();
System.Console.WriteLine($"Разница между максимальным и минимальным значением массива составляет: {diff}");


