// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.

// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []


static int GetSortedArray(string[] array, int maxElementLength)
{
    int count = 0;
    for (int index = 0; index < array.Length; index++)
    {
        if (array[index].Length <= maxElementLength)
        {
            string temp = array[count];
            array[count] = array[index];
            array[index] = temp;
            count++;
        }
    }
    return count;
}

static void PrintArray(string[] array)
{
    if (array.Length > 0)
    {
        Console.Write("[\"");
        string print = string.Join("\", \"", array);
        Console.Write(print);
        Console.Write("\"]");
    }
    else
        Console.Write("[]");
}

static void PrintResult(string[] array, int maxElementLength)
{
    PrintArray(array);
    Console.Write(" -> ");
    int length = GetSortedArray(array, maxElementLength);
    Array.Resize(ref array, length);
    PrintArray(array);
    Console.WriteLine();
}

string[] Array1 = new string[] { "hello", "2", "world", ":-)" };
int maxElementLength = 3;

Console.Clear();
PrintResult(Array1, maxElementLength);

