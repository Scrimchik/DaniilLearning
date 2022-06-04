using System;

namespace Enum.Models
{
    public class Worker
    {
        public Worker(string name, int internship)
        {
            Name = name;
            Internship = internship;
        }

        public string Name { get; set; }
        public int Internship { get; set; }
        //1 - working
        //2 - resting
        //3 - on dinner
        public int Status { get; set; }

        public void StartWork()
        {
            Status = 1;
        }

        public void StartResting()
        {
            Status = 2;
        }

        public void GoToTheDinner()
        {
            Status = 3;
        }

        public void ShowStatus()
        {
            switch (Status)
            {
                case 1:
                    Console.WriteLine("Working");
                    break;
                case 2:
                    Console.WriteLine("Resting");
                    break;
                case 3:
                    Console.WriteLine("On dinner");
                    break;
            }
        }
    }
}
