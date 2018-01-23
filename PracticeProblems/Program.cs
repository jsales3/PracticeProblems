using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myName = "Jovon Sales";
            //string favCar = "Telsa";
            //string comHero = "SpiderMan";

            ////displays full name, favorite car, and favorite comic book hero
            //Console.WriteLine("Hi my name is, " + myName);
            //Console.WriteLine("My favorite car is a " + favCar + ", because it can self drive");
            //Console.WriteLine("My favorite comic book hero is " + comHero);

            //double total = 7;
            //total = total - 2;
            //Console.WriteLine(total + " cups");

            //total = 4;
            //total = total * 13;
            //Console.WriteLine("$" + total);

            //total = 40;
            //total = total / 8;
            //Console.WriteLine(total + " packages");

            //total = 41;
            //total = total - 29;
            //Console.WriteLine("$" + total);

            //total = 47;
            //total -= 30;
            //Console.WriteLine(total + " miles");

            //total = 12;
            //total /= 3;
            //Console.WriteLine(total);

            //total = 27.10;
            //total = total + 5.12;
            //Console.WriteLine(total);

            /***********************************************/

            double amount = 2;
            double total = 7;

            total = total - amount;
            Console.WriteLine(total + " cups");

            total = 4;
            amount = 13;
            total = total * amount;
            Console.WriteLine("$" + total);

            total = 40;
            amount = 8;
            total /= amount;
            Console.WriteLine(total + " packages");

            total = 41;
            amount = 29;
            total -= amount;
            Console.WriteLine("$" + total);

            total = 47;
            amount = 30;
            total -= amount;
            Console.WriteLine(total + " miles");

            total = 12;
            amount = 3;
            total /= amount;
            Console.WriteLine(total);

            total = 27.10;
            amount = 5.12;
            total += amount;
            Console.WriteLine(total);








            //string myName1;
            //string favcar1;
            //string comHero1;

            //Console.WriteLine("Hi, what's your name?");
            //myName1 = Console.ReadLine();
            //Console.WriteLine("Hi " + myName1 + " What is your favorite car?");

            //favcar1 = Console.ReadLine();
            //Console.WriteLine(favcar1 + "? " + "that's cool, what's your favorite comic book super hero?");

            //comHero1 = Console.ReadLine();
            //Console.WriteLine("Wow!, I love " + comHero1 + " too!");

        }
    }
}
