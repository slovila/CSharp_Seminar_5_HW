//Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

int[] GenerateArray(int length , int min = 100, int max = 999)
{
    int[] newArray = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = rnd.Next(min, max + 1); // (]
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

System.Console.WriteLine("Введите количество элементов массива > ");
int n = Convert.ToInt32(Console.ReadLine());

int[] arrayNum = GenerateArray(n);
System.Console.Write("Полученный массив > ");
PrintArray(arrayNum);

int count = 0;
for (int i = 0; i < arrayNum.Length; i++)
{
    if(arrayNum[i] % 2 == 0)
    count++;
}
System.Console.WriteLine();
System.Console.WriteLine($"Количество четных значений массива : {count} ");

