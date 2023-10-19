//напишите программу , которая принимает число и проверяет , кратно ли оно одноврменно 7 и 23
System.Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int number1= 7;                                //можно не делать переменные!!
int number2 = 23;                                 
if ( number%number1 ==0  & number%number2 == 0)//if (number%7==0 && number%23==0 )
{
    System.Console.WriteLine("ДА , КРАТНО");
}
else
{
    System.Console.WriteLine("нет");
}