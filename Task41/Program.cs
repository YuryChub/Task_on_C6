// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.Clear();
Console.Write("Введите количество чисел: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите любые целые числа: ");
int counter = 0;
int i = 1;
while (i <= M)
{    
    int n = Convert.ToInt32(Console.ReadLine());   
        if (n > 0)
        counter = counter + 1;
i++;
}
Console.WriteLine($"Количество чисел больше 0: {counter}");