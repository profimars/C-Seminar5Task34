// Задача 34: Задайте массив заполненный случайными положительными трёхзначными 
// числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
//https://github.com/profimars/C-Seminar5Task34
void FillArray(int[] AA)
{
    for (int i = 0; i < AA.Length; i++)
        AA[i] = new Random().Next(100, 1000);
}

void PrintArray(int[] AA)
{
    foreach (int element in AA)
    {
        Console.Write($"{element}; ");
    }
    Console.WriteLine();
}

int CountPozitivNumbers(int[] AA)
{
    int k = 0;
    for (int i = 0; i < AA.Length; i++)
    {
        if (AA[i] % 2 == 0)
            k = k + 1;
    }
    return k;
}

Console.WriteLine("Введите количество элементов в массиве а");
int a = Convert.ToInt32(Console.ReadLine());
int[] AA = new int[a];
FillArray(AA);
PrintArray(AA);
int rez = CountPozitivNumbers(AA);
Console.WriteLine("Количество чётных чисел в массиве = " + rez);