﻿using System;

namespace P04.CleverLily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•Възрастта на Лили - цяло число в интервала [1...77]
            int lilysAge = int.Parse(Console.ReadLine());
            //•Цената на пералнята - число в интервала[1.00...10 000.00]
            double washingMachinePrice = double.Parse(Console.ReadLine());
            //•Единична цена на играчка -цяло число в интервала[0...40]
            int toyPrice = int.Parse(Console.ReadLine());
            int savedMoney = 0;

            for (int i = 1; i <= lilysAge; i++) 
            {
                if (i%2==0) //•За четните рождени дни(2, 4, 6...n) получава пари. 
                {
                    savedMoney += i* 5 - 1;
                }
                else //•За нечетните рождени дни (1, 3, 5...n) получава играчки.
                {
                    savedMoney += toyPrice;
                }
            }

            if(savedMoney >= washingMachinePrice)
            {
                Console.WriteLine($"Yes! {savedMoney-washingMachinePrice:f2}");
            }
            else
            {
                Console.WriteLine($"No! {washingMachinePrice-savedMoney:f2}");
            }

        }
    }
}
