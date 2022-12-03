/*
    Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

    5 -> 2, 4
    8 -> 2, 4, 6, 8
*/

int N = 5;
int count = 1;
string res = ""; 
while (count <= N)
{
    if (count % 2 == 0)
    {
        res = res + count + ", ";
    }
    
    count++;
}

Console.WriteLine(res.TrimEnd(new Char[] {',', ' '}));