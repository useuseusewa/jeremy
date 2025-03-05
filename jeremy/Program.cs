using System;

public class Calculator
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Консольный калькулятор");

        while (true)
        {
            Console.WriteLine("Введите первое число:");
            if (!double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.WriteLine("Некорректный ввод числа. Попробуйте снова.");
                continue;
            }

            Console.WriteLine("Введите оператор (+, -, *, /):");
            string operation = Console.ReadLine();

            Console.WriteLine("Введите второе число:");
            if (!double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.WriteLine("Некорректный ввод числа. Попробуйте снова.");
                continue;
            }

            double result = 0;

            try
            {
                switch (operation)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        if (num2 == 0)
                        {
                            Console.WriteLine("Деление на ноль!");
                            continue;
                        }
                        result = num1 / num2;
                        break;
                    default:
                        Console.WriteLine("Некорректный оператор.");
                        continue;
                }

                Console.WriteLine("Результат: " + result);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}"); // Обработка любых других исключений
            }

            Console.WriteLine("Вы хотите выполнить еще одну операцию? (да/нет)");
            string answer = Console.ReadLine().ToLower();
            if (answer != "да")
            {
                break;
            }
        }

        Console.WriteLine("Спасибо за использование калькулятора!");
    }
}