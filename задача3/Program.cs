//Напишите программу , которая будет принимать на вход два числа и выводить, является ли второе число
//... кратное первому .Если число2 не кратно 1 , то программа выводит остаток от деления 
System.Console.WriteLine("Введите два числа ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int ostatok = number1%number2;
if (ostatok==0)
{
System.Console.WriteLine("кратно");
}
else
{
    System.Console.WriteLine($" не кратно , остаток {ostatok}");
}
