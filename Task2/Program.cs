// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
//в промежутке от M до N с помощью рекурсии.


int m = 3, n = 2;
do
{
    m = Prompt("Введите первое число: ");
    n = Prompt("Введите второе число(должно быть больше первого): ");
}
while (m >= n);
int sum = SumOfIntegers(m, n);
System.Console.WriteLine($"Сумма натуральных чисел от {m} до {n}:  {sum}");



int Prompt(string message)      
{
    System.Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = int.Parse(value);
    return result;
}
int SumOfIntegers(int a, int b, int sumInt = 0)     
{
    if (a > b) return sumInt;
    if (a <= 0)
    {
        a = 1;
    }
    sumInt += a;
    return SumOfIntegers(a + 1, b, sumInt);
}