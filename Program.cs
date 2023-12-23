/* Задача: Написать программу, 
которая из имеющегося массива строк 
формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []

 */

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

string InputString(string message)
{
    Console.Write(message);
    return Console.ReadLine()!;
}

string[] CreateArray(int size)
{
    return new string[size];
}

void FillArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = InputString($"Введи элемент {i + 1}: ");
    }
}
void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

string[] CreateNewArray(string[] arr)
{
    int lengthNewArr = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            lengthNewArr++;
        }
    }
    string[] res = CreateArray(lengthNewArr);
    int k = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            res[k] = arr[i];
            k++;
        }
    }
    return res;
}
int size = InputNum("Введи длину массива: ");
string[] array = CreateArray(size);
FillArray(array);
PrintArray(array);
string[] array2 = CreateNewArray(array);
PrintArray(array2);