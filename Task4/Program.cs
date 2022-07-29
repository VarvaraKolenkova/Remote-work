// See https://aka.ms/new-console-template for more information
int[] array = {8, -5, 6, 5, 17, 3};

int find = -5;
foreach (var item in array)
{
    if(item == find) 
    {
        Console.WriteLine("Да"); 
        return;
    }    
}
Console.WriteLine("Нет");
 