
// Задача 19
// // Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом. 
// (палиндром - число читается слева направо и справа налево одинаково)
// // 14212 -> нет
// // 12821 -> да
// // 23432 -> да

// Console.WriteLine("Введите пятизначное число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// char[] arr = N.ToString().ToCharArray();

// if(arr.Length == 5 && arr[0]==arr[4] && arr[1]==arr[3]) 
// {
//     Console.WriteLine("да");
// }
// if(arr.Length == 5 && arr[0]!=arr[4] || arr[1]!=arr[3])
// {
//     Console.WriteLine("нет");
// }
// if(arr.Length != 5)
// {
//     Console.WriteLine("число не пятизначное");
// }








// // Задача 21
// // Напишите программу, которая принимает 
// на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// // A (3,6,8); B (2,1,-7), -> 15.84
// // A (7,-5, 0); B (1,-1,9) -> 11.53


// Console.Write("Введите число x1: ");
// string text_x1 = Console.ReadLine();
// int x1 = Convert.ToInt32(text_x1);

// Console.Write("Введите число y1: ");
// string text_y1 = Console.ReadLine();
// int y1 = Convert.ToInt32(text_y1);

// Console.Write("Введите число z1: ");
// string text_z1 = Console.ReadLine();
// int z1 = Convert.ToInt32(text_z1);

// Console.Write("Введите число x2: ");
// string text_x2 = Console.ReadLine();
// int x2 = Convert.ToInt32(text_x2);

// Console.Write("Введите число y2: ");
// string text_y2 = Console.ReadLine();
// int y2 = Convert.ToInt32(text_y2);

// Console.Write("Введите число z2: ");
// string text_z2 = Console.ReadLine();
// int z2 = Convert.ToInt32(text_z2);

// double AB = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));

// Console.WriteLine($"Расстояние между точками А и В: {AB}");









// // Задача 23
// // Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


// Console.WriteLine("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= N; Console.Write(i * i * i + ", "), i++);
