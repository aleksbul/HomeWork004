// Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.


int[] Array(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(0, 100);
    }

    return result;
}

int[] array = Array(8);
Console.WriteLine($"[{String.Join(", ", array)}]");
