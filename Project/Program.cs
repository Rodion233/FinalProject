string Prompt(string message)
{
    Console.WriteLine(message);
    return Console.ReadLine();
}

string[] FillArray(int size)
{
    string[] arr = new string[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Prompt($"Введите {i} элемент: ");
    }

    return arr;
}

int CntWordsLess3Symbols(string[] arr)
{
    int count = 0;
    foreach (string str in arr)
    {
        if (str.Length <= 3)
        {
            count++;
        }
    }

    return count;
}

string[] CpLess3Symbols(string[] initialArr)
{
    int copySize = CntWordsLess3Symbols(initialArr);
    string[] newArr = new string[copySize];

    int count = 0;
    foreach (string str in initialArr)
    {
        if (str.Length <= 3)
        {
            newArr[count++] = str;
        }
    }

    return newArr;
}

void ShowArr(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

int size = Int32.Parse(Prompt("Размер массива: "));
string[] arr = FillArray(size);
string[] duplicate = CpLess3Symbols(arr);
ShowArr(duplicate);