﻿// Задача 21: Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние между ними в 3D пространстве.
// Например:
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координату Х точки A");
int xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату У точки A");
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z точки A");
int za = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Х точки B");
int xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату У точки B");
int yb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z точки B");
int zb = Convert.ToInt32(Console.ReadLine());

double res = Math.Sqrt(Math.Pow(xa - xb, 2) + Math.Pow(ya - yb, 2) + Math.Pow(za - zb, 2));
Console.WriteLine($"{res:f2}");
