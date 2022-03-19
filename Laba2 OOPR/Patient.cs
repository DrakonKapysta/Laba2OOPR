using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2_OOPR
{
     public class Patient : Human
    {
        public Patient(string name, string surname, string state, int age, string problemDec = "No description") : base(age, name, surname, state)
        {
            ProblemDescription = problemDec; 
        }
        public Patient() { }
        public string ProblemDescription { get; set; }
        public string HealingDoctor { get; set; }
        public new bool BeHealthy { get; set; } = false;
        public override void Work(Task task)
        {
            task.SingSongs();
        }
    }
}
