using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace finallab
{
      public class HourlyEmployee : Employee
    {
        int fixedsalary = 500;

      public override  void CalculateSalary()
        {

            if (hoursWorked > BASE_HOURS)
            {
                basePay = hourlyPayRate * BASE_HOURS;
                overtimePay = hoursWorked - BASE_HOURS;
                overtimePay = overtimeHours * hourlyPayRate * OVERTIME_RATE;
                unitPay = 3 * unitprodused;
                Grosspay = basePay + overtimePay + unitPay;
            }
        }
    }
}