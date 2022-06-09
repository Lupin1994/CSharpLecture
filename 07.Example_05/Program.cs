// Перебор слов
// В некотором машинном алфавите имеются 4 буквы "а" "и" "с" "в". 
// Покажите все слова, состоящие из Т букв, которые можно построить из букв этого алфавита.

char[] s = { 'а', 'и', 'с','в'};
int count = s.Length;
int n = 1;
for (int i = 0; i < count; i++)
{
    for (int j = 0; j < count; j++)
    {
        for (int k = 0; k < count; k++)
        {
            for (int l = 0; l < count; l++)
            {
                for (int m = 0; m < count; m++)
                {
                    Console.WriteLine($"{n++,-5}{s[i]}{s[j]}{s[k]}{s[l]}{s[m]}");
                }
            }
        }  
    }
}