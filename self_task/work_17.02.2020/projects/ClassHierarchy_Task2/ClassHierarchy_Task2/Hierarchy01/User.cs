using System;


namespace ClassHierarchy_Task2.Hierarchy01
{
    class User
    {
        protected string name;
        protected int age;

        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }
        public void Setage(int age)
        {
            this.age = age;
        }
        public int Getage()
        {
            return age;
        }
    }
}
