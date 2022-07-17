// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Enter the k1 value: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the k2 value: ");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the b1 value: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the b2 value: ");
int b2 = Convert.ToInt32(Console.ReadLine());

double difference1 = b2 - b1;
double difference2 = k1 - k2;
double x = difference1 / difference2;
double y = k1 * x + b1;

Console.WriteLine($"The intersection point is located at coordinates x = {x} and y = {y}");

