//Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.



int[] ArrayFill(){     //Ввод массива чисел 
    System.Console.WriteLine("Массив чисел: ");
    int length = new Random().Next(5,15);
    int[] array1 = new int [length]; 
    for (int i= 0; i <array1.Length; i++){
        array1[i] = new Random().Next(100,1000);
    }
    return array1;
}


int NumberOfEven(int[] array){      
    int count=0;
    for (int i= 0; i <array.Length; i++){
        if(array[i]%2==0)
            count++;
    }
    return count;
}
void ArrayPrint(int[] array){       
    for (int i= 0; i <array.Length; i++){
        System.Console.Write(array[i] + " ");
    } 
    System.Console.WriteLine();
}



int[] arr = ArrayFill();
ArrayPrint(arr);
int result = NumberOfEven(arr);
System.Console.WriteLine("Количество четных чисел в массиве: " + result);