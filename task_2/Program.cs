﻿/*   Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных
     уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
Console.WriteLine("Введите число начала прямой: ");
var b1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите число начало второй прямой: ");
var k1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите число конца прямой: ");
var b2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите число конца второй прямой: ");
var k2 = Convert.ToDouble(Console.ReadLine());

var x = -(b1 - b2) / (k1 - k2);
var y = k1 * x + b1;
 
x = Math.Round(x, 3);
y = Math.Round(y, 3);
 
Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({x};{y})");