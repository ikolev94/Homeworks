using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human_Student_and_Worker
{
    class Worker : Human
    {
        private decimal weekSalary;
        private decimal workHoursPerDay;
        public Worker(string first, string last,decimal weekSalary,decimal workHoursPerDay)
            : base(first, last)
        {
            this.WorkHoursPerDay = workHoursPerDay;
            this.WeekSalary = weekSalary;
        }
        

        public decimal MoneyPerHour()
        {
            decimal money = (this.WeekSalary/5)/this.WorkHoursPerDay;
            return money;
        }
        public decimal WeekSalary { get; set; }

        public decimal WorkHoursPerDay { get; set; }

    }
}
