using System;

namespace ClassHierarchy.Hierarchy02
{
    abstract class Content
    {


            public int ID { get; set; }
            public string Name { get; set; }
            public DateTime UploadDate { get; set; }


            public Content(int id, string name, DateTime uploadDate)
            {
                ID = id;
                Name = name;
                UploadDate = uploadDate;
            }

            public override string ToString()
            {
                return $"Номер: {ID}, Название: {Name}, Дата: {UploadDate}";
            }


    }
}
