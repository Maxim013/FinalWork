//  Написать программу, 
//  которая из имеющегося массива строк формирует новый массив из строк,
//  длина которых меньше, либо равна 3 символам. 
//  Первоначальный массив можно ввести с клавиатуры, 
//  либо задать на старте выполнения алгоритма. 
//  При решении не рекомендуется пользоваться коллекциями, 
//  лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []




Console.Write("Сколько элементов Вы хотите ввести? ");
int size = int.Parse(Console.ReadLine() ?? "0");
string[] arrayStrings = new string[size];
int pos = 0;
for (int i = 0; i < size; i++)
{
   Console.WriteLine($"Введите {i + 1}-й элемент: ");
   string element = Console.ReadLine() ?? "0";
   if (element.Length <= 3)
   {
        arrayStrings[pos] = element;
        pos++;
   }
}
Console.WriteLine();

void PrintArray(string[] arr)
{
    Console.Write("[" + arr[0] + " ");
    for (int i = 1; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i]);
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
    Console.WriteLine();
}

PrintArray(arrayStrings);