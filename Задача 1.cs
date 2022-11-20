// Ввести два числа и сравнить их

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
    if(a > b)
    {
        Console.WriteLine($"Число {a} > числа {b} ");
    }
    else if(a < b)
    {
        Console.WriteLine($"Число {a} < числа {b}");
    }
    else
    {
        Console.WriteLine($"Число {a} = числу {b}");
    }