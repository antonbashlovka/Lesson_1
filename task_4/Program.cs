/*
    Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

    2, 3, 7 -> 7
    44 5 78 -> 78
    22 3 9 -> 22
*/

int a = 2, b = 3, c = 7;
int max = a;

if (b > max) {max = b;}
if (c > max) {max = c;}

Console.WriteLine("max = " + max);


a = 4; 
b = 5; 
c = 78;
max = a;

if (b > max) {max = b;}
if (c > max) {max = c;}

Console.WriteLine("max = " + max);


a = 22; 
b = 3; 
c = 9;
max = a;

if (b > max) {max = b;}
if (c > max) {max = c;}

Console.WriteLine("max = " + max);