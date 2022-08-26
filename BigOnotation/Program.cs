
// int n = 5;
// int[] array = new int[n];
// for (int i = 0; i < n; i++)
//     array[i] = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("[" + string.Join(", ", array) + "]");
// // [2, 5, 1, 4, 3,]
// // O(n)
// // [1, 2, 3, 4, 5] = O(n* log n)
// // ((5 + 1)/2)*5 = O(1)
// // n < n * log(n) + 1
// int summ = 0;
// for (int i = 0; i < n; i++);
//     summ += array[i];

// Console.WriteLine(summ);

// int n = Convert.ToInt32(Console.ReadLine());
// int[, ] matrix = new int[n, n];
// for (int i = 0; i < n; i++)
// {
//     for (int j = i; j < n; j++)
//     {
//         matrix[i, j] = (i + 1) * (j + 1);
//         matrix[j, i] = (i + 1) * (j + 1);
//         // Console.Write(i * j / 2);
//         // Console.Write("\t");
//     }
//     Console.WriteLine();
// }
// for (int i = 0; i < n; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         Console.Write(matrix[i, j]);
//         Console.Write(" ");
//     }
//     Console.WriteLine();

string[] array = { "POCO", "SOLO", "Po", "1", "--"};



Console.WriteLine(array[1]);
Console.WriteLine("[" + string.Join(", ", array) + "]");