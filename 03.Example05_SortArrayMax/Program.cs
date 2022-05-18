int[] arr = { 1, 5, 9, 14, 3, 6, 8, 10, 2 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        int MaxPosition = i;
        for (int j = i+1;j < array.Length; j++)
        {
            if (array[j]>array[MaxPosition]) MaxPosition = j;
        }
        int Temprorary = array[i];
        array[i] = array[MaxPosition];
        array[MaxPosition] = Temprorary;
    }
    Console.WriteLine(array.Length);
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);