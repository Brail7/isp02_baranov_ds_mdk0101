using System;


namespace ClassHierarchy.Hierarchy02
{
    class Video : Content
    {
        public double Length { get; set; }


        public Video(double length, int id, string name, DateTime uploadDate)
            : base(id, name, uploadDate)
        {
            Length = length;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Длина видео: {Length}";
        }
    }

}
