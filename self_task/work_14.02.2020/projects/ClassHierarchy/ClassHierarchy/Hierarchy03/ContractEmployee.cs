using System;


namespace ClassHierarchy.Hierarchy03
{
    class ContractEmployee : Employee
    {
        public float PayPerHour { get; set; }
        public string ContractPeriod { get; set; }

        public ContractEmployee(float payPerHour, string contractPeriod, int ID, string Name)
            : base(ID, Name)
        {
            PayPerHour = payPerHour;
            ContractPeriod = contractPeriod;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Оплата за час: {PayPerHour}, Контрактный период: {ContractPeriod}";
        }
    }
}

