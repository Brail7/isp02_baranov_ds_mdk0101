using System;

namespace ClassHierarchy.Hierarchy02
{
    class Photo : Content
    {
        public int WhoIsOnPicture { get; set; }


        public Photo(int whoIsOnPicture, int id, string name, DateTime uploadDate)
            : base(id, name, uploadDate)
        {
            whoIsOnPicture = WhoIsOnPicture;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, На фото: {WhoIsOnPicture}";
        }

    }

}
