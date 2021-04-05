using System;

namespace _0405
{
    class PropertyWithoutField
    {
        public string Message
        {
            get { return Console.ReadLine(); }
            set { Console.WriteLine(value); }
        }
    }
    class PropertyWithoutFieldApp

    {
        public static void Main()
        {
            PropertyWithoutField obj = new PropertyWithoutField();
            obj.Message = obj.Message;
        }
    }
}