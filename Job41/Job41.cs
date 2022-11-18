/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Например:
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

int GetQuantityNumber(string message) 
{
    int digit;
    while(true)
    {
        Console.Write(message);
        if(int.TryParse(Console.ReadLine(), out int quantityNumbers) && quantityNumbers > 0 && quantityNumbers < 21)
        {
            digit = quantityNumbers;
            break;
        }
        else
        {
            Console.WriteLine($"{quantityNumbers} - Введены не корректные данные. Повторите ввод \n");
        }
    }
    return digit;
} 
int quantityNumbers = GetQuantityNumber("Введите количество _M_ цифр, которые хотите ввести:\t ");

int[] array = new int[quantityNumbers];
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"\nВведите отрицательное или положительное число с порядковым индексом {i}:\t ");
    array[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine();

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"[{array[i]}] ");
    }
    Console.WriteLine();
}

void GreatZero(int[] array)
{
int result = 0;   
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 0)
        result = result + 1;
    }
    Console.WriteLine($"\nВведенных чисел больше _0_ в итоге получилось _{result}_.");
}

PrintArray(array);
GreatZero(array);
