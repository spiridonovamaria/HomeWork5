// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.



float[] ArrayFill()
{
    System.Console.WriteLine("Массив чисел: ");
    int length = new Random().Next(5, 10);
    float[] array1 = new float[length];
    for (int i = 0; i < array1.Length; i++)
    {
        array1[i] = new Random().Next(-27, 27);
    }
    return array1;
}

float MinSearch(float[] array)
{   
    float min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}


float MaxSearch(float[] array)
{    
    float max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}

float MinMaxDifference(float min, float max)
{     
    float diff = 0;
    if (min < 0)
    {
        diff = -min + max;
    }
    else if (max < 0)
    {
        diff = -(min - max);
    }
    else
    {
        diff = max - min;
    }
    return diff;
}
void ArrayPrint(float[] array)
{      
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}



float[] arr = ArrayFill();
ArrayPrint(arr);
float min = MinSearch(arr);
float max = MaxSearch(arr);
System.Console.WriteLine($"Mаксимальный элемент: {max}\nМинимальный элемент: {min}");
float result = MinMaxDifference(min, max);
System.Console.WriteLine("Разница между минимальным и максимальным элементами массива: " + result);