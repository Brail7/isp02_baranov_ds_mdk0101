using System;
using System.Collections.Generic;

namespace ClassHierarchy.Hierarchy01
{
    class Teacher : Person
    {

        private List<string> disciplines;

        public Teacher(string name, int age, List<string> disciplines)
           : base(age, name)
        {
            this.disciplines = disciplines;
        }

        public void AddDiscipline(string discipline)
        {
            disciplines.Add(discipline);
        }

        public void RemoveDiscipline(string discipline)
        {
            disciplines.RemoveAt(disciplines.IndexOf(discipline));

        }

        public override string ToString()
        { 
            string stDisciplines = "";
            foreach (string i in disciplines)
                stDisciplines += i + " ";
                return $"{base.ToString()}, Дисциплины: {stDisciplines}";
        }

        public override void Print()
        {
            Console.WriteLine(ToString());
        }

    }
}

