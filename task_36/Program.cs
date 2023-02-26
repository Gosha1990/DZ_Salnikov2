// Задача 36: Задайте одномерный массив, заполненный 
// случайными числами. Найдите сумму элементов, стоящих на 
// нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// int[] array = new int[5];
var sum = 0;
 int size = 5;
int[] array = new int[size];
for (int i = 0; i < size; i++)
{
array[i] = new Random().Next(-99, 99);
    if (i % 2 == 1)
    {
        sum += array[i];       
        }
     
}
Console.WriteLine($"Массив: [{String.Join("; ", array)}]");
Console.WriteLine($"Сумма элементов на нечетных позициях: {sum}");

