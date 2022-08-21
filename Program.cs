//2. Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

//Console.Write("Введите первое число: ");
//int firstNumber = Convert.ToInt32(Console.ReadLine());

//Console.Write("Введите второе число: ");
//int secondNumber = Convert.ToInt32(Console.ReadLine());

//if (firstNumber > secondNumber)
//{
//    Console.WriteLine("max = " + firstNumber);
//}
//else Console.WriteLine("max = " + secondNumber);


//4. Напишите программу, которая принимает на вход три числа и
// выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

//Console.Write("Введите первое число: ");
//int firstNumber = Convert.ToInt32(Console.ReadLine());

//Console.Write("Введите второе число: ");
//int secondNumber = Convert.ToInt32(Console.ReadLine());

//Console.Write("Введите третье число: ");
//int thirdNumber = Convert.ToInt32(Console.ReadLine());

//int max = firstNumber;
//if (secondNumber >= max) max = secondNumber;
//if (thirdNumber >= max) max = thirdNumber;
//Console.WriteLine("Максимальное число = " + max);


//6. Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет

//Console.Write("Введите число: ");
//int Number = Convert.ToInt32(Console.ReadLine());

//if (Number % 2 == 0) Console.WriteLine("Число четное");
//else Console.WriteLine("Число не четное");


//8. Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int even = 2;
while (even <= N)
{
    Console.WriteLine(even);
    even = even + 2;
}

