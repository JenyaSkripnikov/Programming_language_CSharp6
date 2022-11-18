/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
Например:
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

int GetNumberK1(string message) 
{
    int digit;
    while(true)
    {
        Console.Write(message);
        if(int.TryParse(Console.ReadLine(), out int numberK1))
        {
            digit = numberK1;
            break;
        }
        else
        {
            Console.WriteLine($"{numberK1} - Введены не корректные данные. Повторите ввод \n");
        }
    }
    return digit;
} 
int GetNumberB1(string message) 

{
    int digit;
    while(true)
    {
        Console.Write(message);
        if(int.TryParse(Console.ReadLine(), out int numberB1))
        {
            digit = numberB1;
            break;
        }
        else
        {
            Console.WriteLine($"{numberB1} - Введены не корректные данные. Повторите ввод \n");
        }
    }
    return digit;
} 
int GetNumberK2(string message) 
{
    int digit;
    while(true)
    {
        Console.Write(message);
        if(int.TryParse(Console.ReadLine(), out int numberK2))
        {
            digit = numberK2;
            break;
        }
        else
        {
            Console.WriteLine($"{numberK2} - Введены не корректные данные. Повторите ввод \n");
        }
    }
    return digit;
} 
int GetNumberB2(string message) 

{
    int digit;
    while(true)
    {
        Console.Write(message);
        if(int.TryParse(Console.ReadLine(), out int numberB2))
        {
            digit = numberB2;
            break;
        }
        else
        {
            Console.WriteLine($"{numberB2} - Введены не корректные данные. Повторите ввод \n");
        }
    }
    return digit;
} 

int numberK1 = GetNumberK1("\nВведите в уранении y = k1 * x + b1 \nотрицательное или положительное число переменной k1:\t ");
int numberB1 = GetNumberB1("\nотрицательное или положительное число переменной b1:\t ");
int numberK2 = GetNumberK2("\nВведите в уранении y = k2 * x + b2 \nотрицательное или положительное число переменной k2:\t ");
int numberB2 = GetNumberB2("\nотрицательное или положительное число переменной b2:\t ");

int numberB0 = numberB1 - numberB2;
int numberK0 = numberK2 - numberK1;
double digitX;
double firstY;
double secondY;
digitX = (Convert.ToDouble(numberB0) / Convert.ToDouble(numberK0));
firstY = Math.Round((numberK1 * digitX + numberB1), 1);
secondY = Math.Round((numberK2 * digitX + numberB2), 1);

if (numberK1 == numberK2 && numberB1 != numberB2)
{
    Console.WriteLine($"\nПрямые y = k1 * x + b1 и y = k2 * x + b2 параллельны.");
}
else if (numberK1 == numberK2 && numberB1 == numberB2)
{
    Console.WriteLine($"\nПрямые y = k1 * x + b1 и y = k2 * x + b2 совпадают.");
}
else if (firstY == secondY)
{
    Console.WriteLine($"\nПрямые y = k1 * x + b1 и y = k2 * x + b2 \nпересекаются в точке (X={Math.Round((digitX), 1)},y={firstY}).");
} 
else
{
    Console.WriteLine($"\nЧто-то полшло не так. Попробуйте снова.");
}