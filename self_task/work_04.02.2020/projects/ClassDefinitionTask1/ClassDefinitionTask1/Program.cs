using System;
using System.Collections.Generic;


namespace ClassDefinitionTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            char line = '_';

            Console.WriteLine(new string(line, 120));
            Console.WriteLine("Студент:");
            Student Alice = new Student("Анна", 2, "Женский");


            Console.WriteLine(Alice.ToString());
            Console.WriteLine(new string(line, 120));

            Console.WriteLine();
            Console.WriteLine("Служащий:");
            Worker worker = new Worker("Иван","Электрик",10);


            Console.WriteLine(worker.ToString());
            Console.WriteLine(new string(line, 120));

            Console.WriteLine();
            Console.WriteLine("Цех:");
            Shop shop = new Shop("df422f",15);


            Console.WriteLine(shop.ToString());
            Console.WriteLine(new string(line, 120));

            Console.WriteLine();
            Console.WriteLine("Книжный магазин:");
            Book book = new Book("Язык программирования C# и платформы .NET", new string[] { "Эндрю Троелсен", "Филипп Джепикс" }, 4800.0 );


            Console.WriteLine(book.ToString());
            Console.WriteLine(new string(line, 120));

            Console.WriteLine();
            Console.WriteLine("Зачёт:");
            RecordBook record_Book = new RecordBook("Виноградов Алексей Викторович", "Виктор Генадьевич Кульков",3);


            Console.WriteLine(record_Book.ToString());
            Console.WriteLine(new string(line, 120));

            Console.WriteLine();
            Console.WriteLine("Адрес: ");
            Address address = new Address(24156,"Волжский","Пушкина","9а",12);

            Console.WriteLine(address.ToString());
            Console.WriteLine(new string(line, 120));

            Console.WriteLine();
            Console.WriteLine("Товар:");
            Product product = new Product("Молоко",20, 60.0, DateTime.Now);


            Console.WriteLine(product.ToString());
            Console.WriteLine(new string(line, 120));

            Console.WriteLine();
            Console.WriteLine("Учебная группа:");
            StudyGroup study_group = new StudyGroup(4263, "Программная инженерия",20,2007);

            Console.WriteLine(study_group.ToString());
            Console.WriteLine(new string(line, 120));

            Console.WriteLine();
            Console.WriteLine("Денежная купюра:");
            Notes notes = new Notes("x 53242", 100,"сто рублей");

            Console.WriteLine(notes.ToString());
            Console.WriteLine(new string(line, 120));

            //Компьютерная игра
            Console.WriteLine();
            Console.WriteLine("Компьютерная игра:");
            PCGame pc_game = new PCGame("Unreal", "Epic Games", 1998, "3D-шутер");

            Console.WriteLine(pc_game.ToString());
            Console.WriteLine(new string(line, 120));

            Console.ReadKey();

        }
    }
}
