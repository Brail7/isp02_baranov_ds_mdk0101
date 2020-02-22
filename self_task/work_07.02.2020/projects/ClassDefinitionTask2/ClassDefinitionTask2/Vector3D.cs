using System;

namespace ClassDefinitionTask2
{

    class Vector3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public Vector3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public double LengthOfVector3D()
        {
            return Math.Sqrt((X * X) + (Y * Y) + (Z * Z));
        }

      static  public double ScalarMult(Vector3D vector1, Vector3D vector2)
        {
            return vector1.X * vector2.X + vector1.Y * vector2.Y + vector1.Z * vector2.Z;
        }

     static   public Vector3D VectorMult(Vector3D vector1, Vector3D vector2)
        {
           return  new Vector3D(vector1.Y * vector2.Z - vector1.Z * vector2.Y,
                vector1.Z * vector2.X - vector1.X * vector2.Z,
                 vector1.X * vector2.Y - vector1.Y * vector2.X);   
        }

        public override string ToString()
        {
            return $"vec(X:{X} ; Y:{Y} ; Z:{Z})";
        }
    }
}
