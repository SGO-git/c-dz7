// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
System.Console.WriteLine("Введите число дня недели");
int Number = Convert.ToInt32(Console.ReadLine());
if (Number > 0 && Number < 8)
{
    if (Number == 6 || Number == 7)
    {
        System.Console.WriteLine("yes");
    }
    else
    {
        System.Console.WriteLine("No");
    }
}
else
{
    System.Console.WriteLine("Wrong number");
}