using System.Collections.Generic;

namespace Generics.Models
{
    class Person
    {
        public object Id { get; } //23, "sadgafdhasdtryuretghs"
        public string Name { get; }

        public Person(object id, string name)
        {
            Id = id;
            Name = name;
        }
    }
    #region Generic
    class SimplePerson<T>
    {
        public T Id { get; set; }
        public string Name { get; set; }

        public SimplePerson(T id, string name)
        {
            Id = id;
            Name = name;
        }

        public void DelaytbMethod<T1>(T1 s) where T1 : Person1
        {
        }
    }
    #endregion

    interface Delaytb
    {
        public void Delatb();
    }

    public class Person1 : Delaytb
    {
        public void Delatb()
        {
            System.Console.WriteLine("Я делаю");
        }
    }
}
