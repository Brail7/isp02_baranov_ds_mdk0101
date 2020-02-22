using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHierarchy.Hierarchy03
{
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Employee(int id, string name)
        {
            ID = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"Номер сотрудника: {ID}, Имя сотрудника: {Name}";
        }

    }

}
