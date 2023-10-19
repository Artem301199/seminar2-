//напишите программу , которая выводит случйное число из отрезка [10,99] и показывает наибольшую цифру числа 
int number = new Random().Next(10,100);
System.Console.WriteLine($"Наше случайное число = {number}");
int digit = number/10;
int digit2 = number%10;
if ( digit>digit2)
{
    System.Console.WriteLine(digit);
}
else if( digit<digit2)
{
    System.Console.WriteLine(digit2);
}
else
{
    System.Console.WriteLine("числа равны");
}