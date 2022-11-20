// Ввести число a и показать все четные числа от -a до a

Console.WriteLine("Введите целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Четные числа от -{a} до {a}: ");
    for (int i = -a; i <= a; i++)
    {
        for (int j = i; j % 2 == 0; j++)
        System.Console.WriteLine(j);
    }