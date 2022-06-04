using Generics.Models;
using System;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(1, "Yura");
            Person person1 = new Person("2", "Danya");

            #region Generic
            SimplePerson<int> person2 = new SimplePerson<int>(1, "Yura");
            SimplePerson<string> person3 = new SimplePerson<string>("2", "Danya");

            person3.DelaytbMethod(new Object());
            #endregion
        }
    }
}
