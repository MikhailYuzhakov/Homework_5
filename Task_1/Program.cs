/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
*/

int count = 0;
int i = 0, j = 0;
int[] array = new int[1000];
Random rnd = new Random();

Console.Clear();
Console.WriteLine("Введите количество элементов в массиве: ");
count = Convert.ToInt32(Console.ReadLine());

Console.Clear();
Console.WriteLine("Сгенерированный массив: ");
genArray(count, 100, 999);

for (i = 0; i < count; i++) {
    if (array[i] % 2 == 0) j++;
}
Console.WriteLine(j);

//------------------------------------------------------------------------
void genArray(int N, int minimum, int maximum) { 
    Console.Write("array[" + count + "] = " + "{");
    for (i = 0; i < N; i++) {
        array[i] = rnd.Next(minimum, maximum);
        if (i != N-1) Console.Write(array[i] + ", ");
        else  Console.Write(array[i]);
    }
    Console.Write("} -> ");
}
