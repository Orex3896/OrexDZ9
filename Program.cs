/*Console.WriteLine("Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1."); 
Console.WriteLine("Выполнить с помощью рекурсии");
void ShowNums(int n)
{
    Console.Write(n + " ");
    if(n>1)
    ShowNums(n-1);
    
}
Console.WriteLine("input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
ShowNums(num);
*/

/*
Console.WriteLine("Задача 66: Задайте значения M и N. Напишите программу,"); 
Console.WriteLine("которая найдёт сумму натуральных элементов в промежутке от M до N");
int ShowSumNums(int m, int n)
{
    if(m<n) return ShowSumNums(m, n-1)+ n;
    return n;
    
   // if (num1>num2) return ShowSumNums(num1-1, num2)+num1;
    //return num1;
    //Здесь не разобрался как сделать если num1>num2
}
Console.Write("Input num1 number ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input num2 number ");
int num2 = Convert.ToInt32(Console.ReadLine());
int res = ShowSumNums(num1,num2);
Console.WriteLine($"Сумма цифр между {num1} и {num2} = {res}");
*/
Console.WriteLine("Задача 68: Напишите программу вычисления функции Аккермана с "); 
Console.WriteLine("помощью рекурсии. Даны два неотрицательных числа m и n.");
    int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}

Console.Write("Input num1 number ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input num2 number ");
int num2 = Convert.ToInt32(Console.ReadLine());
int res = Akkerman(num1,num2);
Console.WriteLine($"функция Аккермана = {res}");
