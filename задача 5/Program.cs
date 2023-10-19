//напишите программу , которая принимает на вход два числа и проверяет , является ли одно число квадратом другого
System.Console.WriteLine("Введите два числа ");
int number = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
if (number*number==number2)
{
    System.Console.WriteLine("да");
}
else
{
    System.Console.WriteLine("нет");
}
