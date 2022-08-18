Console.WriteLine("Введите число");
int number = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Введите степень, в которую требуется возвести число");
int degree = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine (Math.Pow(number, degree));
