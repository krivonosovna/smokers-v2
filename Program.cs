﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp4
{
    internal class Program
    {
        public static tabak? tabak;
        public static bumaga? bumaga;
        public static spichki? spichki;
        private static smoker? smokerWithTabak;
        private static smoker? smokerWithBumaga;
        private static smoker? smokerWithSpichki;
        public static void Main()
        {
            smokerWithTabak = new("tabak");
            smokerWithBumaga = new("bumaga");
            smokerWithSpichki = new("spichki");
            while (true)
            {
                tabak = null;
                bumaga = null;
                spichki = null;
                bool Result = false;
                Result = CreateResources();
                if (Result == false)
                {
                    continue;
                }
                else
                {
                    Thread thread1 = new Thread(() => SmokerWithTabak());
                    Thread thread2 = new Thread(() => SmokerWithBumaga());
                    Thread thread3 = new Thread(() => SmokerWithSpichki());
                    thread1.Start();
                    thread2.Start();
                    thread3.Start();
                    thread1.Join();
                    thread2.Join();
                    thread3.Join();
                }
            }
        }
        public static bool CreateResources()
        {
            Random random = new();
            var a = random.Next(1, 4);
            var b = random.Next(1, 4);
            if (a == b)
            {
                return false;
            }
            else
            {
                if (a + b == 3)
                {
                    tabak = new();
                    bumaga = new();
                    Console.WriteLine("Диллер выложил на стол табак и бумагу");
                }
                else
                {
                    if (a + b == 4)
                    {
                        tabak = new();
                        spichki = new();
                        Console.WriteLine("Диллер выложил на стол табак и спички");
                    }
                    else
                    {
                        spichki = new();
                        bumaga = new();
                        Console.WriteLine("Диллер выложил на стол спички и бумагу");
                    }
                }
            }
            return true;
        }
        public static void SmokerWithTabak()
        {
            if (bumaga != null & spichki != null)
            {
                Cigarette abc;
                abc = smokerWithTabak.makecigarete(bumaga, spichki);
                if (abc == null)
                {
                    return;
                }
                for (int i = 10; i >= 0; i--)
                {
                    Console.WriteLine("Курильщик с табаком курит..." + i);
                    Thread.Sleep(100);
                }
            }
        }
        private static void SmokerWithBumaga()
        {
            if (tabak != null & spichki != null)
            {
                Cigarette abc;
                abc = smokerWithBumaga.makecigarete(tabak, spichki);
                if (abc == null)
                {
                    return;
                }
                for (int i = 10; i >= 0; i--)
                {
                    Console.WriteLine("Курильщик с бумагой курит..." + i);
                    Thread.Sleep(100);
                }
            }
        }
        private static void SmokerWithSpichki()
        {
            if (tabak != null & bumaga != null)
            {
                Cigarette abc;
                abc = smokerWithSpichki.makecigarete(bumaga, tabak);
                if (abc == null)
                {
                    return;
                }
                for (int i = 10; i >= 0; i--)
                {
                    Console.WriteLine("Курильщик со спичками курит..." + i);
                    Thread.Sleep(100);
                }
            }
        }
    }
}