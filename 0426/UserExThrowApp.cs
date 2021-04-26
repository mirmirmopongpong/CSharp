﻿
using System;

namespace project
{
    class UserException : ApplicationException { }
class UserExThrowApp
    {
    static void Method()
    {
        throw new UserException();
    }
    public static void Main()
    {
        try
        {
            Console.WriteLine("Here: 1");
            Method();
            Console.WriteLine("Here: 2");
        }
        catch (UserException)
        {
            Console.WriteLine("User-defined Exception");
        }
    }
}
}