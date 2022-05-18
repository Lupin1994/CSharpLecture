//======= Работа с текстом
//Дан тест. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с".
// Ясна ли задача?

string text = "--  Я думаю, -- сказал  князь улыбаясь, --  что, "
            + "ежели  бы  ваc послали вместо нашего  милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             0123
// s[3] // r

string Replace(string text, char OldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length;i++)
    {
        if(text[i]==OldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text,' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText,'С', 'с');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText,'к', 'К');
Console.WriteLine(newText);      