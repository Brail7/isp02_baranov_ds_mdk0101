using System;
using System.Collections.Generic;
using ClassHierarchy.Hierarchy01;
namespace ClassHierarchy
{
        class Program
        {
            static void Main(string[] args)
            {
                Student student1 = new Student("Орлов Лев Титович", 17, 2, "ИСП-2");
                Student student2 = new Student("Долженко Евсей Ерофеевич", 16, 1, "ИСП-1");
                Teacher teacher1 = new Teacher("Берков Тарас Никанорович", 34, new List<string> { "МДК0101", "МДК0102" });
                Teacher teacher2 = new Teacher("Ягофаров Антон Герасимович", 59, new List<string> { "Высшая математика", "Дискретная математика" });

                Person[] Hierar01 = new Person[4];
                Hierar01[0] = student1;
                Hierar01[1] = student2;
                Hierar01[2] = teacher1;
                Hierar01[3] = teacher2;

                foreach (Person value in Hierar01)
                {
                    Console.WriteLine();
                    Console.WriteLine(value);
                }

                Console.ReadKey();
            }
        }
    }



