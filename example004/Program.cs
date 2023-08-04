/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
int num1 = new Random().Next();
int num2 = new Random().Next();
int num3 = new Random().Next();
int maxChislo = num1;
System.Console.WriteLine($"Сгенерированы 3 числа: {num1}, {num2}, {num3}");
if (num1 == num2 | num1 == num3)
{
    System.Console.WriteLine("Числа равны!!!");
}
else
{
    System.Console.WriteLine("Из них наибольшим является:");
    if (num1 > num2 | num1 > num3)
    {
        System.Console.WriteLine($"Наибольшее число {num1}");
    }
    else
    {
    System.Console.WriteLine(num2 > num3 ? num2 : num3);
    }
}
