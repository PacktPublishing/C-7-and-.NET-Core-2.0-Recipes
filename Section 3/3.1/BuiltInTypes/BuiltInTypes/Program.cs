using System;

namespace BuiltInTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool
            bool myBool = true;
            Console.WriteLine("bool: {0}", myBool.GetType());

            //byte
            byte myByte = 4;
            Console.WriteLine("byte: {0}", myByte.GetType());

            //sbyte
            sbyte mySByte = 9;
            Console.WriteLine("sbyte: {0}", mySByte.GetType());

            char myChar = 'A';
            Console.WriteLine("char: {0}", myChar.GetType());

            //short
            short myShort = 1;
            Console.WriteLine("short: {0}", myShort.GetType());

            //ushort
            ushort myUnsignedShort = 10;
            Console.WriteLine("ushort: {0}", myUnsignedShort.GetType());

            //int
            int myInt = 8;
            Console.WriteLine("int: {0}", myInt.GetType());

            //uint
            uint myUnsigned = 28;
            Console.WriteLine("uint: {0}", myUnsigned.GetType());

            //long
            long myLongInt = 10000000000000;
            Console.WriteLine("long: {0}", myLongInt.GetType());

            //ulong
            ulong myUnsignedLong = 200000000000000;
            Console.WriteLine("ulong: {0}", myUnsignedLong.GetType());

            //float
            float myFloat = 3.14F;
            Console.WriteLine("float: {0}", myFloat.GetType());

            //double
            double myDouble = 28.456874296;
            Console.WriteLine("double: {0}", myDouble.GetType());

            //decimal
            decimal myDecimal = 45932870952.34255252353M;
            Console.WriteLine("decimal: {0}", myDecimal.GetType());

            //string
            string myString = "Hello C#";
            Console.WriteLine("string: {0}", myString.GetType());

            Console.ReadKey();
        }
    }
}