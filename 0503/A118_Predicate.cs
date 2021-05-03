﻿
using System;
using System.Collections.Generic;


namespace program
{
    class A118_Predicate
    {
        static void Main(string[] args)
        {
            Predicate<int> isEven = n => n % 2 == 0;
            Console.WriteLine(isEven(6));
            Predicate<string> isLowerCase = s => s.Equals(s.ToLower());
            Console.WriteLine(isLowerCase("This is a lowercase string"));
        }
        static bool IsEven(int n) => n % 2 == 0;
        static bool IsLowerCase(string s) => s.Equals(s.ToLower());
    }
}