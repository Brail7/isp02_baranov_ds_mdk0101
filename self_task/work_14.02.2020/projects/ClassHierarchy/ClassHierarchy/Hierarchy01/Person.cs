using System;


namespace ClassHierarchy.Hierarchy01
{
    class Person
    {

        private int age;
        private string name;


        public Person(int age, string name)
        {
            this.age = age;
            this.name = name;
        }


        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetAge(int age)
        {
            this.age = age;
        }

        public virtual void Print()
        {
            Console.WriteLine($"Имя: {name}, Возраст: {age}");
        }

        public override string ToString()
        {
            return $"Имя: {name}, Возраст: {age}";
        }



    }

}
