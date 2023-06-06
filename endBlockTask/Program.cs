
Console.Clear();

string[] arrayOne = new string[3] { "Hello", "2", ":-)" };
//string[] arrayOne = new string[4] { "1234", "1567", "-2", "computer science" };
//string[] arrayOne = new string[3] { "Russia", "Denmark", "Kazan" };

string[] arrayTwo = new string[arrayOne.Length];

NewSecondArray(arrayOne, arrayTwo);

PrintArray(arrayOne);
Console.Write(" -> ");
PrintArray(arrayTwo);

void NewSecondArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
}

