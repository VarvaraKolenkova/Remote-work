// Алгоритм сортировки массива от max к min
int [] arr = {8, 5, 8, 12, 9, 1, 3, 85};

void PrintArray (int [] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}
void SelectionSort(int [] array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        int maxPosition = i;
        for (int j = i+1; j < array.Length; j++)
        {
            if(array[j] > array[maxPosition]) maxPosition = j;
        }
        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}

SelectionSort(arr);
PrintArray(arr);

