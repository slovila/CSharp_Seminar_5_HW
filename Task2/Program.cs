//Задача 2: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

int[] GenerateArray()
{
    System.Console.Write("Введите количество элементов массива > ");
    int length = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Введите минимальное значение элемента массива > ");
    int min = Convert.ToInt32(Console.ReadLine());
    System.Console.Write("Введите максимальное значение элемента массива > ");
    int max = Convert.ToInt32(Console.ReadLine());
    int[] newArray = new int[length];

    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = new Random().Next(min, max + 1); //( Int32.MinValue, Int32.MaxValue );
    }
    return newArray;
}


void PrintArray(int[] array)
{
    System.Console.Write('[');
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($" {array[i]} ");
    }
    System.Console.Write(']');
}

int[] array = GenerateArray();
PrintArray(array);
int sum = 0;
for (int count = 1; count < array.Length; count += 2)
{
    sum = sum + array[count];
}
System.Console.WriteLine();
System.Console.WriteLine($"Сумма значений элементов не четных позиций: {sum} ");
