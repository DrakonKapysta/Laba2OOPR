using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2_OOPR
{
    public class Doctor : Human
    {
        public Doctor(int age, string name, string surname, string state) : base(age, name, surname, state){}
        public override void Work(Task task)
        {
            
        }
        public new void BeHealthy()
        {
            base.BeHealthy();
        }
        public Doctor() { }
        private List<Patient> _patientList = new List<Patient>();
        public void AddPatient(Patient newPatient)
        {
            _patientList.Add(newPatient);
        }
    }
}
