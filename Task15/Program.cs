// Задача 15: 
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру от 1 до 7, обозначающую день недели");
int num = Convert.ToInt32(Console.ReadLine());

if ((num < 1)||(num > 7))
{ 
    Console.WriteLine("Дня недели, обозначающего введенной цифрой нет!");
}
else if (num > 5)
{
    Console.WriteLine("Выходной день");
}
else
{
    Console.WriteLine("Будний день");
}