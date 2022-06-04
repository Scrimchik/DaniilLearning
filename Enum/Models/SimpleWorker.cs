using System;

namespace Enum.Models
{
    public class SimpleWorker
    {
        public SimpleWorker(string name, int internship)
        {
            Name = name;
            Internship = internship;
        }

        public string Name { get; set; }
        public int Internship { get; set; }
        public WorkerStatus Status { get; set; }
        public AliveStatus Alive { get; set; }

        public void StartWork()
        {
            Status = WorkerStatus.Working;
        }

        public void StartResting()
        {
            Status = WorkerStatus.Resting;
        }

        public void GoToTheDinner()
        {
            Status = WorkerStatus.OnDinner;
        }

        public void ShowStatus()
        {
            switch (Status)
            {
                case WorkerStatus.Working:
                    Console.WriteLine("Working");
                    break;
                case WorkerStatus.Resting:
                    Console.WriteLine("Resting");
                    break;
                case WorkerStatus.OnDinner:
                    Console.WriteLine("On dinner");
                    break;
            }
        }
    }

    public enum AliveStatus
    {
        Alive,
        Died,
        DontKnow
    }

    public enum WorkerStatus
    {
        Working,
        Resting,
        OnDinner
    }
}
