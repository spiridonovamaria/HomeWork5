// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.



int[] ArrayFill()
{
    System.Console.WriteLine("Массив чисел: ");
    int length = new Random().Next(3, 10);
    int[] array1 = new int[length];
    for (int i = 0; i < array1.Length; i++)
    {
        array1[i] = new Random().Next(-25, 25);
    }
    return array1;
}


int SumOfOddPositions(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}
void ArrayPrint(int[] array)
{       //Вывод массива в консоль
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}



int[] arr = ArrayFill();
ArrayPrint(arr);
int result = SumOfOddPositions(arr);
System.Console.WriteLine("Сумма элементов нечетных позиций: " + result);