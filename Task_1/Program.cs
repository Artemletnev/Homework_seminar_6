//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("How many digits will be entered? ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter numbers with ENTER: ");
string[] arrayFromString = new string[M];
int positiveDigit = 0;
for(int i = 0; i < arrayFromString.Length; i++)
{
   arrayFromString[i] = Console.ReadLine();
}
for (int i = 0; i < arrayFromString.Length; i++)
{
    int convertToInt = Convert.ToInt32(arrayFromString[i]);
    if(convertToInt > 0)
    {
        positiveDigit++;
    }

}
Console.WriteLine($"{positiveDigit} positive numbers have been entered");





