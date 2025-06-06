using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FitnessApp
{
    public class UserGoal
    {
        public string Name { get; set; }
        public string ActivityType { get; set; }
        public double TargetValue { get; set; } // км для бега/велосипеда
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsCompleted { get; set; }

        public string Description => $"{Name} ({ActivityType} {TargetValue} км до {EndDate:dd.MM})";
    }


    public class ActivityRecord
    {
        public int Id { get; set; }
        public string ActivityType { get; set; }
        public DateTime Date { get; set; }
        public double Distance { get; set; }
        public TimeSpan Duration { get; set; }
        public double AvgSpeed { get; set; }
        public int Calories { get; set; }
    }
}
