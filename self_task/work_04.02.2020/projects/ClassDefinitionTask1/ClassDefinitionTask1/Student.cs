using System;


namespace ClassDefinitionTask1
{
    class Student
    {
        public string Name { set; get; }
        public int Course { set; get; }
        public readonly string gender;

        public Student(string name, int course,string gender)
        {
            Name = name;
            Course = course;
            this.gender = gender;
        }

        public override string ToString()
        {
            return $"Имя: {Name} Курс: {Course}, Пол: {gender}";
        }
    }

}
