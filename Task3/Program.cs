// Замена знаков в массиве на противоположные
int[] GetArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
    return array;
}
int[] ChangeSignArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
      array[i] = - array[i];     
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.WriteLine(string.Join(", ", array));
}
int[] array = GetArray(12);
PrintArray(array);
Console.WriteLine(string.Join(", ", ChangeSignArray(array)));