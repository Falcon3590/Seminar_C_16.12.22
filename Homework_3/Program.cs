//Задача 3*. Найдите сумму произведений пар чисел в одномерном целочисленном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//Если кол-во элементов нечетное, то элемент посередине не учитывать.
//Результат сложения вывести на экран.
//1, 3, 8, 3, 2 -> 11
//8, 3, 4, 2 -> 28

int[] arr = {2, 3, 5, 3, 2};
int n = arr.Length;
int ind2 = arr.Length - 1;
int result = 0;

for (int i = 0; i < n / 2; i++){
result += arr[i] * arr[ind2];
ind2--;
}
Console.WriteLine($"Сумма произведений пар чисел = {result}");

















// int findProductSum(int[] a, int n)
// {
//     int product = 0;
//     for (int i = 0; i < n; i++)
//         for (int j = i + 1; j < n; j++)
//             product = product + a[i] * a[j];
//     return product;
// }

//     int[] a = {2, 3, 3, 2};
//     int n = a.Length;
//     Console.WriteLine("sum of product of all " +
//                       "pairs of array elements : ");
//     Console.WriteLine(findProductSum(a, n));

