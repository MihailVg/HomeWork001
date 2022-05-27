//Задача N4 по определению четных чисел до заданного числа

Console.WriteLine("Введите число, четные до которого вы хотите определить: ");

int numberA = int.Parse(Console.ReadLine());
int numberB = 1;

while(numberB <= numberA)
{
    if(numberB % 2 == 0)
    {
        Console.WriteLine(numberB);
        numberB += 1;
    }
    else
    {
        numberB += 1;
    }
}
