//Задача N2 по определению наибольшего из трех чисел 

Console.Write("Введите три числа, которые хотите сравнить: ");

int numberA = int.Parse(Console.ReadLine());
int numberB = int.Parse(Console.ReadLine());
int numberC = int.Parse(Console.ReadLine());
int max = numberA;

if(numberB > max) max = numberB;
if(numberC > max) max = numberC;

Console.Write("Наибольшим числом является: ");
Console.Write(max);
