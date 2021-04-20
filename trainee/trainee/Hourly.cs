using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trainee
{
    class Hourly:Employee
    {
        public Hourly(string FCS, int pay, DateTime start, DateTime finish, bool convection) : base(FCS, pay, start, finish, convection)
        {

        }
        public new string Info()
        {
            return base.Info();
        }
        public override int PayCheck()
        {
            return 0;
        }
    }
}
