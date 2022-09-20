// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. Не пользоватсья коллекциями.
// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["12345", "1567", "-2", "computer scince"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

string[] arrString1 = new string[4] { "12345", "1567", "-2", "computer scince" };
string[] arrString2 = new string[arrString1.Length];

void FillSecondArray(string[] arrString1, string[] arrString2)
{
    int count = 0;
    int n = 3;
    for (int i = 0; i < arrString1.Length; i++)
    {
        if (arrString1[i].Length <= n)
        {
            arrString2[count] = arrString1[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
FillSecondArray(arrString1, arrString2);
PrintArray(arrString2);
