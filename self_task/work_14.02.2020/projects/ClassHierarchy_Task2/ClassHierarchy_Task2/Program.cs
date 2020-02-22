using System;
using ClassHierarchy_Task2.Hierarchy01;
namespace ClassHierarchy_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker ivan = new Worker();
            ivan.Setage(25);
            ivan.SetSalary(1000);
            Worker vasya = new Worker();
            vasya.Setage(26);
            vasya.SetSalary(2000);
            double sum = vasya.GetSalary() + ivan.GetSalary();
        }
    }
}
