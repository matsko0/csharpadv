using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04.Domain.Models
{
    public class Manager : Employee
    {
        private double baseSalary;
        private double bonus;

        public Manager(string name, int id, double baseSalary, double bonus)
            : base(name, id)
        {
            this.BaseSalary = baseSalary;
            this.Bonus = bonus;

        }
        private double BaseSalary
        {
            get { return baseSalary; }
            set { baseSalary = value > 0 ? value : 0; }
        }
        private double Bonus
        {
            get { return bonus; }
            set { bonus = value >= 0 ? value : 0; }
        }

        public override double CalculateSalary()
        {
            return BaseSalary + Bonus;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Manager Info:{Name} and with ID:{Id} gets have Salary: {CalculateSalary()} ");
        }
    }
}
