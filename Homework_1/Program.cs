//Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//Не использовать массив.
//M=5 ; 0, 7, 8, -2, -2 -> 2
//M=5 ; -1, -7, 567, 89, 223 -> 3


int tmp = 0;
int result = 0;
Console.WriteLine("Введите 10 чисел через Enter");

for (int i = 0; i < 10; i++)
{
    tmp = Convert.ToInt32(Console.ReadLine());
    if (tmp > 0)
    {result++;}
}
Console.Clear();
Console.WriteLine($"Пользователь ввел чисел больше 0  = {result}");
Console.ReadKey();