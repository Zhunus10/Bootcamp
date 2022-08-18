 /*
 1.константные
 2.Логарифмические
 3. Линейные
 4. Линейно-логарифмические (quick sorting, merger(sliyanie) sorting )
 5. Квадратичные
 6. Кубические
 */
  
  // 1 Const
// int n = 0;
// if (n >= 0)
//     n++;
// else
//     n*= 2;

// 3.Linear Algorithm
// y = kx + b

// int n = Convert.ToInt32(Console.ReadLine());
// int result = 1;
// for (int i = 1; i <=n; i ++)
//     result = result * i;
// Console.WriteLine(result);
// factorial - on of the  linear algorith

// 2. Binar searching - log algorithm 

// 5. Square algorithm


// int count = 0;
// for (int i = 0; i < 5; i ++)
// {
//     for (int j = 0; j < 5; j ++)
//         count++;
// }
// Console.WriteLine(count);

// Evclid algorithm - greatest common divisor GCD (naibolshiy obshiy delitel НОД)
// exampl GCK (14, 21) = 7
int n = 140;
int m = 175;
int count = n * m;
while (n != m)
{
    if (n > m)
        n = n - m;
    else
        m = m - n;
Console.WriteLine(n);
Console.WriteLine(m);
Console.WriteLine();
}
// НОК
Console.WriteLine(count / n);



    




