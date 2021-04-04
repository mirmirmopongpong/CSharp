using System;

namespace Project
{
    class IfStApp
    {
        static int x;
        static void Main(string[] args)
        {
            int x = (IfStApp.x = 2) * 2;
            Console.WriteLine("static x = " +IfStApp.x);
            Console.WriteLine("local x = " +x);


        }
    }
}
