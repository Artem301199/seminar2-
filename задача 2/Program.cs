//напишите программу , которая выводит случайное трехзначное число и удаляет вторую цифру этого чсила 
int number = new Random().Next(100,1000);
System.Console.WriteLine(number);
int number1 = number/100;
int number2 = number%10;
int number3 = number1*10+number2;
System.Console.WriteLine(number3);