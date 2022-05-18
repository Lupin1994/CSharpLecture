// Вид 1
void Method1()
{
    Console.WriteLine("Автор ......");
}
//Method1(); //Вызов метода

// Вид 2
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2(msg: "Текст сообщения");

void Method2_1(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }

}
//Method2_1(msg: "Text", count: 4);
//Method2_1(count: 4, msg:"NewText");


//Вид 3
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
//Console.WriteLine(year);

//Вид 4 Вариант 1 (Через цикл While)
// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;
//     while (i<count)
//     {
//         result = result +text;
//         i++;
//     }
//     return result;

// }
// Вариант 2 (Через цикл for)
string Method4(int count, string text)
{

    string result = String.Empty;
    for (int i = 0; i < count;i++)
    {
        result = result + text;
    }
    return result;

}
string res = Method4(10, "Fuck,");
Console.WriteLine(res);