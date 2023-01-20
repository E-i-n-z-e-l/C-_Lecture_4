// string[,] table = new string[2,3]; // указываем, какое количество строчек и столбцов нам нужно(1-е число строчки, 2-е число столбцы). 
// int[,] matrix = new int[5,8];

// string[,] table1 = new string[2,5];
// // String.Empty
// // table [0,0] table [0,1] table [0,2] table [0,4]
// // table [1,0] table [1,1] table [1,2] table [1,4]
// table[1, 2] = "слово";
// for (int rows = 0; rows < 2; rows++)
// {
//  for (int columns = 0; columns < 5; columns++)
//  {
//  Console.WriteLine($"{table[rows, columns]}");
//  }
// }

// int[,] matrix1 = new int[3, 4];
// for (int i = 0; i < matrix.GetLength(0); i++)  // . Для тройки указываем имя массива и новый
//                                                // функционал GetLength(0). 0 в качестве аргумента означает количество строк. Аналогично и для
//                                                // четвёрки: пишем имя массива, точку и GetLength(1).
// {
//  for (int j = 0; j < matrix.GetLength(1); j++)
//  {
//  Console.Write($"{matrix[i, j]} ");
//  }
// }

//РЕКУРСИЯ

// Что такое рекурсия? Это функция, которая вызывает сама себя. 

int Factorial(int n)
{
 // 1! = 1
 // 0! = 1
 if(n == 1) return 1;
 else return n * Factorial(n-1);
}
Console.WriteLine(Factorial(3)); // 1 * 2 * 3 = 6

double Factorial1(int n)
{
 // 1! = 1
 // 0! = 1
 if(n == 1) return 1;
 else return n * Factorial1(n-1);
}
for (int i = 1; i < 40; i++)
{
 Console.WriteLine($"{i}! = {Factorial1(i)}");
}