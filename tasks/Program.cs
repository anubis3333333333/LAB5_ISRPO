using System;

class Program {
    static void Main() {
        Console.WriteLine("=== САМОСТОЯТЕЛЬНЫЕ ЗАДАНИЯ ===");
        
        //Задание 1
        Console.WriteLine("\n[Задание 1. Проверка пароля]");
        Console.Write("Введите пароль: ");
        string pass1 = Console.ReadLine();
        Console.Write("Подтвердите пароль: ");
        string pass2 = Console.ReadLine();
        if (pass1 == pass2) {
            Console.WriteLine("Пароль принят");
        } else {
            Console.WriteLine("Пароль не принят");
        }

        //Задание 2
        Console.WriteLine("\n[Задание 2. Роскомнадзор]");
        Console.Write("Введите ваш возраст: ");
        if (int.TryParse(Console.ReadLine(), out int age)) {
            if (age >= 18) {
                Console.WriteLine("Доступ разрешён");
            } else {
                Console.WriteLine("Доступ запрещён");
            }
        }

        //Задание 3
        Console.WriteLine("\n[Задание 3. Простой калькулятор]");
        Console.Write("Введите первое число: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Введите второе число: ");
        double num2 = double.Parse(Console.ReadLine());
        Console.Write("Введите операцию (+, -, *, /): ");
        string op = Console.ReadLine();

        switch (op) {
            case "+":
                Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                break;
            case "-":
                Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                break;
            case "*":
                Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                break;
            case "/":
                if (num2 != 0) {
                    Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                } else {
                    Console.WriteLine("Ошибка: деление на ноль!");
                }
                break;
            default:
                Console.WriteLine("Неверная операция");
                break;
        }

        //Задание 4
        Console.WriteLine("\n[Задание 4. Только положительные]");
        double sum = 0;
        for (int i = 1; i <= 3; i++) {
            Console.Write($"Введите число {i}: ");
            double n = double.Parse(Console.ReadLine());
            if (n > 0) {
                sum += n;
            }
        }
        Console.WriteLine($"Сумма только положительных чисел: {sum}");

        //Задание 5
        Console.WriteLine("\n[Задание 5. Путешествие в Тёмный Лабиринт]");
        Console.WriteLine("Вы стоите перед первой дверью. Перед вами два пути:");
        Console.WriteLine("Путь A: Войти в комнату с огромным драконом.");
        Console.WriteLine("Путь B: Пойти по тёмному коридору.");
        Console.Write("Ваш выбор (A/B): ");
        string choice1 = Console.ReadLine().ToUpper();

        if (choice1 == "A") {
            Console.WriteLine("Дракон говорит: \"Кто не дышит, но живёт; хоть не нужно — много пьёт; и в жизни, и в смерти тело как лёд.\"");
            Console.Write("Ваш ответ: ");
            string answer = Console.ReadLine().ToLower().Trim();
            if (answer == "рыба") {
                Console.WriteLine("Правильно! Дракон открывает дверь к сокровищам. Вы победили!");
            } else {
                Console.WriteLine("Неверно! Дракон вас съел... Конец игры.");
            }
        } else if (choice1 == "B") {
            Console.WriteLine("Вы попали в тёмную комнату. Перед вами две двери:");
            Console.WriteLine("Дверь 1: Ведёт к сокровищам.");
            Console.WriteLine("Дверь 2: Ведёт в ловушку.");
            Console.Write("Какую дверь выберете? (1/2): ");
            string choice2 = Console.ReadLine();
            if (choice2 == "1") {
                Console.WriteLine("Ура! Вы нашли сокровища Dungeon Master'а! Победа!");
            } else {
                Console.WriteLine("Бам! Вы попали в ловушку с ядовитыми шипами. Игра окончена.");
            }
        } else {
            Console.WriteLine("Вы испугались и убежали.");
        }
    }
}
