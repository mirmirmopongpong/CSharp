using System;


namespace Basic
{
    class Overflow
    {
        static void Main(string[] args)
        {
            int x = 10, y = 0;
            try
            {
                Console.WriteLine(x / y);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
