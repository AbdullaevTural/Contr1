
Console.WriteLine("Введите массив строк через пробел");
string stroka = Console.ReadLine();
string[] Array3(string stroka)
{
    string[] M = stroka.Split(' ');
    string[] result = new string[M.Length];
    int realSize = 0;
    foreach (var value in M)
    {
        if (value.Length <= 3)
        {
            result[realSize] = value;
            realSize++;
        }

    }
    return result;
}

string[] array = Array3(stroka);

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
PrintArray(array);