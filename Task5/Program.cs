// See https://aka.ms/new-console-template for more information

int[] GetArrayRandom(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1, 150);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.WriteLine(string.Join(", ", array));
}

int[] array = GetArrayRandom(123);
PrintArray(array);

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 9 && array[i] < 100)
    {
        count+=1;
    }
}
System.Console.WriteLine(count);