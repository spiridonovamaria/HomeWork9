// Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа 
//в промежутке от M до N с помощью рекурсии.



int m = 3, n = 2;
do
{
    m = Prompt("Введите первое число: ");
    n = Prompt("Введите второе число(должно быть больше первого): ");
}
while (m >= n);
System.Console.WriteLine($"Четные натуральные числа от {m} до {n}: ");
EvenNumbers(m, n);



int Prompt(string message)     
{
    System.Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = int.Parse(value);
    if (result < 1)
    {
        throw new Exception("Необходимо натуральное число!");
    }
    else return result;
}


void EvenNumbers(int a, int b)
{
    if (a > b) return;
    if (a % 2 != 0)
    {
        a++;
    }
    System.Console.Write(a + " ");
    EvenNumbers(a + 2, b);
}