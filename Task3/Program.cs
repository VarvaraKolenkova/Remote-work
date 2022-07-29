// See https://aka.ms/new-console-template for more information
/* int ReversSignArray (int[] array)
{
    foreach (int elem in array)
    {
        array[i] = - array[i];
    }
    return array1;
} */
int[] GetArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
    return array;
}

/* void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
} */
void PrintArray(int[] array)
{
    Console.WriteLine(string.Join(", ", array));
}
int[] array = GetArray(12);
//int[] array = new int[12];
//FillArray(array);
PrintArray(array);
//Console.WriteLine($"Массив наоборот: {ReversSignArray(array)}");