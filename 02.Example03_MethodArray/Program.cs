int[] array = { 1, 23, 345, 456, 4, 2, 6, 56, 4 };

int n = array.Length;
int find = 4;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}