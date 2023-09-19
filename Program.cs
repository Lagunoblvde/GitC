using System.Diagnostics.CodeAnalysis;

bool exit = false;
Console.WriteLine("Вас приветствует калькулятор МПТ \nВыберите действие, которое хотите выполнить");
Console.WriteLine("1. Сложение \n2. Вычитание \n3. Умножение \n4. Деление \n5. Возведение в степень \n6. Извлечение квадратного корня \n7. Процент от числа \n8. Факториал \n9. Выйти");
int answer_1 = Convert.ToInt32(Console.ReadLine());
if (answer_1 == 1)
{
    while(exit == false)
    {
        Console.WriteLine("Введите первое число: ");
        int number_1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число: ");
        int number_2 = Convert.ToInt32(Console.ReadLine());
        int sum = number_1 + number_2;
        Console.WriteLine(number_1 + "+" + number_2 + "=" + sum);
        Console.WriteLine("Выйти в главное меню: Да/Нет");
        string answer_2 = Console.ReadLine();
        if (answer_2 == "Да")
        {
            break;
        }
    }
} 
if (answer_1 == 2)
{
    Console.WriteLine("Введите первое число: ");
    int number_1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число: ");
    int number_2 = Convert.ToInt32(Console.ReadLine());
    int sum = number_1 - number_2;
    Console.WriteLine(number_1 + "-" + number_2 + "=" + sum);
} 
if (answer_1 == 3)
{Console.WriteLine("Введите первое число: ");
    int number_1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число: ");
    int number_2 = Convert.ToInt32(Console.ReadLine());
    int sum = number_1 * number_2;
    Console.WriteLine(number_1 + "*" + number_2 + "=" + sum);
} 
if (answer_1 == 4)
{
    Console.WriteLine("Введите первое число: ");
    float number_1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число: ");
    float number_2 = Convert.ToInt32(Console.ReadLine());
    if (number_2 == 0)
    {
        Console.WriteLine("Ошибка, делить на ноль нельзя!");
    }
    float sum = number_1 / number_2;
    Console.WriteLine(number_1 + "/" + number_2 + "=" + sum);
}
if (answer_1 == 5)
{
    Console.WriteLine("Введите первое число: ");
    int number_1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите степень, в которую хотите возвести число: ");
    int number_2 = Convert.ToInt32(Console.ReadLine());
    double sum = Math.Pow(number_1,number_2);
    Console.WriteLine(number_1 + "^" + number_2 + "=" + sum);
}
if (answer_1 == 6)
{
    Console.WriteLine("Введите число в квадрате: ");
    double number_1 = Convert.ToInt32(Console.ReadLine());
    
    double sum = Math.Sqrt(number_1);
    Console.WriteLine(number_1 + "=" + sum);
}
if (answer_1 == 7)
{
    Console.WriteLine("Введите первое число: ");
    double number_1 = Convert.ToInt32(Console.ReadLine());
    double sum = number_1 / 100;
    Console.WriteLine(number_1 + "=" + sum);
}
if (answer_1 == 8)
{
    Console.WriteLine("Введите первое число: ");
    int number_1 = Convert.ToInt32(Console.ReadLine());
    int sum = 1;
    for (int n = 2; n <= number_1; n++)
    {
        sum *= n;
        if (n == number_1)
        {
            Console.WriteLine(number_1 + "=" + sum);
        }
    }
}
if (answer_1 == 9)
{
    Console.WriteLine("Всего хорошего!");
    return;
}

