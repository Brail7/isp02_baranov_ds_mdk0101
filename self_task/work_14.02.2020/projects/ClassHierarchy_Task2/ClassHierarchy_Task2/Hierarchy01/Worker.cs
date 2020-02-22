using System;


namespace ClassHierarchy_Task2.Hierarchy01
{
    class Worker : User
    {
        private double salary;
        public void SetSalary(double salary)
        {
            this.salary = salary;
        }
        public double GetSalary()
        {
            return salary;
        }
    }
}
