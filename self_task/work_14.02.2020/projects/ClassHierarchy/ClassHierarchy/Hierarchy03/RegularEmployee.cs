using System;

namespace ClassHierarchy.Hierarchy03
{
    class RegularEmployee : Employee
    {
        public float Salary { get; set; }
        public int Bonus { get; set; }

        public RegularEmployee(float salary, int bonus, int ID, string Name)
            : base(ID, Name)
        {
            Salary = salary;
            Bonus = bonus;
        }
        public override string ToString()
        {
            return $"{base.ToString()}, Зарплата: {Salary}, Премия: {Bonus}";
        }

    }

}
