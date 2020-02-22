using System;


namespace ClassHierarchy_Task2.Hierarchy01
{
    class Student : User
    {
        private double scholarship;
        private int course;
        public void SetScholarship(double scholarship)
        {
            this.scholarship = scholarship;
        }
        public double GetScholarship()
        {
            return scholarship;
        }
        public void Setcourse(int course)
        {
            this.course = course;
        }
        public int Getcourse()
        {
            return course;
        }
    }
}
