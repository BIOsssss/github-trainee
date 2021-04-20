using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trainee
{
    abstract class Employee
    {
        //
        private string FCS { get; set; }
        private int pay { get; set; }
        private DateTime start { get; set; }
        private DateTime finish { get; set; }
        private bool convection { get; set; }
        //
        public Employee(string FCS, int pay, DateTime start, DateTime finish, bool convection)
        {
            this.FCS = FCS;
            this.pay = pay;
            this.start = start;
            this.finish = finish;
            this.convection = convection;
        }
        //
        public string Info()
        {
            return $@"FCS = {FCS}
Pay = {pay:c}
Start = {start}
Finish = {finish}
Convection = {convection}";
        }
        public abstract int PayCheck();
        public int CountEmpl()
        {
            int count = 0;
            return count;
        }
        public int SrPay()
        {
            int payCh = PayCheck();
            int empl = CountEmpl();
            int sr = 0;
            return sr;
        }
    }
}
