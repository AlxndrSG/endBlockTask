
Console.Clear();

int size = Prompt("Введите длинну массива: ", "Ошибка! Введены некорректные данные!");

string[] arrayOne = new string[size];
Console.WriteLine($"Введите элементы массива через 'Enter': ");

FillArray(arrayOne);

int n = Prompt("Введите количество символов размера элемента массива: ", "Ошибка! Введены некорректные данные!");
int secondSize = FindSecondSize(arrayOne);

string[] arrayTwo = TransferElementFromArrayOne(arrayOne);
Console.WriteLine($"[{String.Join(", ", arrayOne)}] -> [{String.Join(", ", arrayTwo)}]");

void FillArray(string[] arr)
{
    for (int i = 0; i < size; i++)
    {
        arr[i] = Console.ReadLine()!;
    }
}

string[] TransferElementFromArrayOne(string[] arr)
{
    string[] arrayTwo = new string[secondSize];
    for (int i = 0, j = 0; i < size; i++)
    {
        if (arr[i].Length <= n)
        {
            arrayTwo[j] = arr[i];
            j++;
        }
    }
    return arrayTwo;
}

int FindSecondSize(string[] arr)
{
    int sizeSecond = 0;
    for (int i = 0; i < size; i++)
    {
        if (arr[i].Length <= n)
            sizeSecond++;
    }
    return sizeSecond;
}

int Prompt(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int userInput))
        {
            return userInput;
        }
        else Console.WriteLine(errorMessage);
    }
}


