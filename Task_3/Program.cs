/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
*/

int count = 0;
int i = 0;
int max, min, cap;
double[] array = new double[1000];
Random rnd = new Random();

Console.Clear();
Console.WriteLine("Введите количество элементов в массиве: ");
count = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2 целочисленные переменные для рандомизации генерации массива: ");
max = Convert.ToInt32(Console.ReadLine());
min = Convert.ToInt32(Console.ReadLine());

if (min > max) {
    cap = max;
    max = min;
    min = cap;
}
cap = 0;

Console.Clear();
Console.WriteLine("Сгенерированный массив: ");
genArray(count, min, max);


Console.WriteLine(Math.Round(findMaxMin(), 2));

//------------------------------------------------------------------------
void genArray(int N, int minimum, int maximum) { 
    Console.Write("array[" + count + "] = " + "{");
    for (i = 1; i <= N; i++) {
        array[i-1] = rnd.NextDouble() * rnd.Next(minimum, maximum) * i;
        if (i != N) Console.Write(Math.Round(array[i-1], 2) + "; ");
        else  Console.Write(Math.Round(array[i-1], 2));
    }
    Console.Write("} -> ");
}
//------------------------------------------------------------------------
double findMaxMin() { 
    double max_element = 0;
    double min_element = 20000000;

    for (i = 0; i < count; i++) {
        if (array[i] > max_element) max_element = array[i];
        if (array[i] < min_element) min_element = array[i];
    }
    return Math.Abs(max_element - min_element);
}