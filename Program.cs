// Задача:
// Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

// Примеры:

// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.Write("Введите количество элементов массива: ");
int l = 0;
int.TryParse(Console.ReadLine()!, out l);
string[] array = new string[l];
for (int i = 0; i <= array.Length - 1; i++)
{
    Console.Write($"Введите {i}-ый элемент массива: ");
    array[i] = Console.ReadLine();
}
int lNewArray = 0;
for (int i = 0; i <= array.Length - 1; i++)
{
    if (array[i].Length <= 3) lNewArray++;
}

string[] newArray = new string[lNewArray];
int j = 0;

for (int i = 0; i <= array.Length - 1; i++)
{
    if (array[i].Length <= 3)
    {
        newArray[j] = array[i];
        j++;
    }
}
PrintArray(array);
Console.Write(" -> ");
PrintArray(newArray);
void PrintArray(string[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"“{array[i]}”, ");
    }
    Console.Write("] ");
}