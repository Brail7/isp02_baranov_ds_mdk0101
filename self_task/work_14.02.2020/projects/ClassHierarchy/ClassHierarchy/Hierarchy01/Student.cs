using System;


namespace ClassHierarchy.Hierarchy01
{

        class Student : Person
        {

            private int course;
            private string group;

            public Student(string name, int age, int course, string group)
                : base(age, name)
            {
                this.course = course;
                this.group = group;
            }

            public void NextCourse(int course)
            {
                this.course = course;
            }

            public override string ToString()
            {
                return $"{base.ToString()}, Группа: {group},  Курс: {course}";
            }

            public override void Print()
            {
                Console.WriteLine(ToString());
            }

        }
    }


