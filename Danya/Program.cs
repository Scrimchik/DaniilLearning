using System;
using System.IO;

namespace Danya
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 3200;
            byte b = 10;

            a = b;
            b = (byte)a;
        }
    }
}
