﻿/*
 ДЗ №27 до 07.11.23_CS_введение1

Задание 1. Пользователь вводит с клавиатуры число в диапазоне от 1 до
100. Если число кратно 3 (делится на 3 без остатка) нужно вывести слово
Fizz. Если число кратно 5 нужно вывести слово Buzz. Если число кратно 3
и 5 нужно вывести Fizz Buzz. Если число не кратно не 3 и 5 нужно вывести
само число. Если пользователь ввел значение не в диапазоне от 1 до 100
требуется вывести сообщение об ошибке.

Задание 2. Пользователь вводит с клавиатуры показания температуры. В
зависимости от выбора пользователя программа переводит температуру из
Фаренгейта в Цельсий или наоборот.

 */

using System;

namespace ДЗ__27_до_07._11._23__CS_введение1_Задание_2
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Показание температуры: ");
            double tempReadings;
            tempReadings = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите единицу измерения C или F (англ.заглавные): ");
            string choice;
            choice = Console.ReadLine();

            double ConvertToFar = tempReadings + 33.8;
            double ConvertToCels = tempReadings - 17.22;

            if (choice == "C" | choice == "F" )
            {
                if (choice == "C")
                    Console.WriteLine("Введенное значения показания температуры в Цельсиях: " + tempReadings +  " С,"+
                        "\nчто соответствует значению в единицах измерения Фаренгейт: " + ConvertToFar + " F");

                else
                    Console.WriteLine("Введенное значения показания температуры в Фаренгейтах: " + tempReadings + " F," +
                        "\nчто соответствует значению в единицах измерения Цельсия: " + ConvertToCels + " С");
            }

            else
                Console.WriteLine("Ошибка!Единица измерения должна быть 'C' или 'F' (англ.заглавные)");

        }
    }
}
