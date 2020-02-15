using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITCompanyExt.BLL
{
    public class Employee
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }

        public Employee()
        {
        }

        public Employee(long id, string name, string position, double salary, string department)
        {
            Id = id;
            Name = name;
            Position = position;
            Salary = salary;
            Department = department;
        }

        public override string ToString()
        {
            return Name.ToString();
        }

        //void MeDelegMeating EventHandler(Meeting m)
        //{

        //}
        //public abstract void DoWork(Employee e);
        //public abstract void MakeReport(Employee e, string title, string body, DateTime ReportDate);
        //public abstract void TakeVacation(Employee e, DateTime DateFrom, DateTime DateTo);
        //public abstract void PerformTask(Employee e, DateTime DateFrom, DateTime DateTo, Employee executor);
    }
}
