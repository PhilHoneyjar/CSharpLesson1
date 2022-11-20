// Ввести число a и показать все четные числа от 1 до a

Console.WriteLine("Введите целое положительное число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Четные числа от 1 до {a}: ");
    for (int i = 1; i <= a; i++)
    {
        for (int j = i; j % 2 == 0; j++)
        System.Console.WriteLine(j);
    }
