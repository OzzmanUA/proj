using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    internal class Worker
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public bool IsOfficial { get; set; }
        public double Salary { get; set; }
        public double MonthSalary
        {
            get
            {
                if (IsOfficial) return (Salary - ((Salary / 100) * 19.5)) * 30;
                else return Salary * 30;
            }
        }
        public bool OnPension
        {
            get
            {
                if (Age >= 60) return true;
                else return false;
            }
        }

        public Worker(string name, string surname, int age, bool isOfficial, double salary)
        {
            Name = name;
            Surname = surname;
            Age = age;
            IsOfficial = isOfficial;
            Salary = salary;
        }
        public override string ToString()
        {
            return $"Worker {Surname} {Name}, age = {Age} and salary = {Salary}";
        }
    }
}
