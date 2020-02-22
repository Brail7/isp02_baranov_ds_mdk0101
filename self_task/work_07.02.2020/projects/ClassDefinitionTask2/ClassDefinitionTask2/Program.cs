using System;

namespace ClassDefinitionTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector3D vect1 = new Vector3D(121, 441, 512);
            Vector3D vect2 = new Vector3D(11, 41, 52);

            Console.WriteLine(vect1.ToString());
            Console.WriteLine(vect2.ToString());

            Console.WriteLine("Длинна вектора 1: " + vect1.LengthOfVector3D());
            Console.WriteLine("Длинна вектора 2: " + vect2.LengthOfVector3D());

            Console.WriteLine("Скалярное произведение вектора 1 и вектора 2: " + Vector3D.ScalarMult(vect1, vect2).ToString());

            Console.WriteLine("Векторное произведение вектора 1 и вектора 2: " + Vector3D.VectorMult(vect1, vect2).ToString());
            Console.ReadKey();
        }
    }
}
