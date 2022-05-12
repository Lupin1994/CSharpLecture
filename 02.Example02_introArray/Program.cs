// Для себя
// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }
// int max = Max(51,86,10);
// Console.WriteLine(max);

      //Массивы

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
    //     i =   0  1    2   3    4  5   6  7  8
int [] array = {11,321,3453,4564,64,767,87,23,43};


int max = Max(
    Max(array[0],array[1],array[2]),
    Max(array[3],array[4],array[5]),
    Max(array[6],array[7],array[8]));

Console.WriteLine(max);

