Console.WriteLine("Введите строки через запятую:");
string[] Array = Console.ReadLine().Split(',');

//новый массив строк с длиной <= 3 символа
string[] Array1 = FilterStrings(Array);

Console.WriteLine("Результат:");
foreach (string str in Array1)
{
    Console.Write($"{str} ");
}

Console.ReadLine();

static string[] FilterStrings(string[] Array)
{
    // количество строк с длиной <= 3 символа
    int count = 0;
    foreach (string str in Array)
    {
        if (str.Length<=3)
        {
            count++;
        }
    }

//новый массив строк
string[] Array1 = new string[count];

int index = 0;
foreach (string str in Array)
{
    if (str.Length<=3)
    {
        Array1[index] = str;
        index++;
    }
}

return Array1;
}