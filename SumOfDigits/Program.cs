Console.WriteLine("Введите число");
int number = Math.Abs (Convert.ToInt32 (Console.ReadLine ()));
int sum = 0;
int derivateNumber = number;
    while (derivateNumber !=0)
        {
            sum = sum + derivateNumber % 10;        // Каждый ход цикла брем цифру из порядка единиц производного числа и прибавляем его к сумме цифр.
            derivateNumber = derivateNumber / 10;   // Кадный ход цикла убираем цифру, которая находилась в порядке единиц производного числа. Условие выхода из цикла - равенство производного ила нулю
        }
Console.WriteLine($"Сумма цифр числа {number} равна {sum}");


