// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Math.Abs(Convert.ToInt32(value));
    return result;
}

string Input(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    return value;
}

string[] CreateStringArray(int size)
{
    string[] newArray = new string[size];
    for(int i = 0; i < size; i++)
    {
        newArray[i] = Input("Input string value of element massive: ");
        Console.WriteLine();
    }
    return newArray;
}

void PrintArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

string[] CreateStringArray3SimbolMax(string[] array)
{
    int countString = 0;
    string[] newSizeArray = new string[countString];
    string[] newArray = newSizeArray;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            countString++;
            newSizeArray = new string[countString];
            for(int j = 0; j < countString - 1; j++)
            {
                newSizeArray[j] = newArray[j];
            }
            newSizeArray[countString - 1] = newArray[i];
            newSizeArray = newArray;
        }
    }
    return newArray;
}