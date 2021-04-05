using System;

namespace _0405
{
    class RWOnlyProperty
    {
        private int readOnlyField = 100;
        private int writeOnlyField;
        public int ReadOnlyProperty
        {
            get
            {
                Console.WriteLine("In the ReadOnlyProperty ...");
                return readOnlyField;
            }
        }
        public int WriteOnlyProperty
        {
            set
            {
                Console.WriteLine("In the WriteOnlyProperty ...");
                writeOnlyField = value;
            }
        }
    }
    class RWOnlyPropertyApp
    {
        public static void Main()
        {
            RWOnlyProperty obj = new RWOnlyProperty();
            obj.WriteOnlyProperty = obj.ReadOnlyProperty;
            Console.WriteLine("value = " + obj.writeOnlyField); // Compile Error
        }
    }
}