// See https://aka.ms/new-console-template for more information

double[] array = {5.1, 8.2, 9.9, 25.8, 3.14, 14.2};
int[] array1 = ConventToInt32(double[] array);

int FindMax(int[] array)
{
int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > max)
        {
            max = array[i];
        }
    }
return max;
}
System.Console.WriteLine(FindMax(array));
int FindMin(int[] array)
{
int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < min)
        {
            min = array[i];
        }
    }
return min;
}
System.Console.WriteLine(FindMin(array));

System.Console.WriteLine(FindMax(array) - FindMin(array));