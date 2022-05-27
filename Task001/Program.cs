//Задача N1 по определению большего из двух чисел

Console.Write("Введите два числа, которые хотите сравнить: ");

int numberA = int.Parse(Console.ReadLine());
int numberB = int.Parse(Console.ReadLine());

if(numberA > numberB)
{
    Console.Write("Наибольшим числом является: ");
    Console.Write(numberA);
}
else
{
    Console.Write("Наибольшим числом является: ");
    Console.Write(numberB);
}
