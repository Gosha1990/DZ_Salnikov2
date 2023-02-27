// Задача 38: Задайте массив вещественных чисел.
//  Найдите разницу между максимальным и минимальным 
//  элементов массива.

// [3 7 22 2 78] -> 76
 int size = 5;
double[] array = new double[size];
for(int i = 0; i < size; i++)
{
array[i] = Math.Round(100 * (new Random().NextDouble()), 2);
}
double max = array[0];
double min = array[0];
for(int i = 0; i < size; i++)
{
if(array[i] > max)
{
max = array[i];
}
if(array[i] < min)
{
min = array[i];
}

 }

 Console.WriteLine($"Массив: [{String.Join("; ", array)}]");
 Console.WriteLine($" минимальное из масива - {min} \n максимальное из масива - {max}");
 Console.WriteLine($"Разница между максимальным и минимальным:  {max - min}");