using System;

namespace Structure.Models
{
    public struct Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public static int MyProperty { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        #region
        public static void Say()
        {
            Console.WriteLine("Hello!");
        }
        #endregion

        #region
        public Person(string name) : this(name, 18)
        {
        }
        #endregion
    }

    #region
    public struct SencondPerson
    {

    }
    #endregion 
}
