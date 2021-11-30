using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace finallab
{
    abstract public class Employee
    {
        int basePay;
        int hoursWorked;
        int BASE_HOURS;
        int overtimePay;
        int Grosspay;
        int unitPay;
        int OVERTIME_RATE;
        int hourlyPayRate = 200;
        int overtimeHours;
        int unitprodused;

        abstract public void CalculateSalary();
    }
}