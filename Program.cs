// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// void Degree(int a, int b)
// {
//     int res = 1;
//     for (int i = 1; i <= b; i++)
//     {
//         res = res * a;
//     }
//     Console.WriteLine(res);
// }

// Console.WriteLine("введите число А");
// int numA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите число Б");
// int numB = Convert.ToInt32(Console.ReadLine());

// Degree(numA, numB);



// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// int CheckCount(int num)
// {
//     int count = 0;
//     int tmp = num;

//     while(tmp > 0)
//     {
//         tmp = tmp / 10;
//         count++;
//     }
//     return count;
// }

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int count = CheckCount(num);
// int res = 0;
// int tmp = num;
// for (int i = 0; i < count; i++)
// {
//      res = res + tmp % 10;
//      tmp = tmp / 10;
// }
// Console.WriteLine(res);


// Напишите программу, которая задаёт 
// массив из 8 элементов и выводит их на экран.

// Random rnd = new Random();
// void PrintArray(int[] array)
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         array[i] = rnd.Next();
//         Console.Write($"{array[i]}, ");
//     }
// }

// int[] arr = new int[8];

// PrintArray(arr);
