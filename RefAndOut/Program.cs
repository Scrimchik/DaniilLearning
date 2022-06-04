using Enum.Models;
using Structure.Models;
using System;

namespace RefAndOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person("Danya", 20);
            //ChangeStruct(person);
            //Console.WriteLine($"Struct after method - Name: {person.Name}, Age: {person.Age}");

            Worker worker = new Worker("Yura", 19);
            ChangeClass(ref worker);
            Console.WriteLine($"Class after method - Name: {worker.Name}, Intership: {worker.Internship}");

            #region refOut
            //Person person = new Person("Danya", 20);
            //Person secondPerson;
            //ChangeSturctWithRefOut(ref person, out secondPerson);
            //Console.WriteLine($"Struct after method - Name: {person.Name}, Age: {person.Age}");
            #endregion
        }

        static void ChangeStruct(Person person)
        {
            person.Name = "Ahmed";
            person.Age = 29;

            Console.WriteLine($"Struct in method - Name: {person.Name}, Age: {person.Age}");
        }

        static void ChangeClass(ref Worker worker)
        {
            worker.Name = "Islam";
            worker.Internship = 44;

            Console.WriteLine($"Class in method - Name: {worker.Name}, Intership: {worker.Internship}");
            worker = new Worker("gdsjklfasdjk", 1234);
        }

        #region refOut
        static void ChangeSturctWithRefOut(ref Person person, out Person secondPerson)
        {
            secondPerson = new Person("Danya", 20);

            person.Name = "Ahmed";
            person.Age = 29;

            Console.WriteLine($"Struct in method with ref - Name: {person.Name}, Age: {person.Age}");
        }
        #endregion
    }
}
