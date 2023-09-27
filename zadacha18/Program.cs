// Напишите программу, которая по заданному номеру четверти, показывает
//диапазон возможных координат точек в этой четверти (x и y).
Console.Write("Введите номер четверти по которой хотите получить координаты:  ");
int number = int.Parse(Console.ReadLine());
Console.Write("Введите число y: ");

if(number == 1)
{
  Console.WriteLine("В первой четверти x > 0, y > 0");  
}
else if (number == 2)
{
  Console.WriteLine("Вo второй четверти x < 0, y > 0");
}
else if (number == 3)
{
  Console.WriteLine("В третьей четверти x < 0, y < 0");
}
else if (number == 4)
{
   Console.WriteLine("В третьей четверти x > 0, y < 0");
}
else  
{
    Console.WriteLine("Введите пожалуйста значение от 1 до 4");
} 

