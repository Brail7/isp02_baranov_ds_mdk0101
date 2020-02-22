using System;


namespace ClassDefinitionTask1
{
    class Book
    {
        public string Heading{get;set;}
        public string[] Authors{get;set;}
        public double Price { get; set; }

        public Book(string heading, string[] authors, double price)
        {
            Heading = heading;
            Authors = authors;
            Price = price;
        }
        public override string ToString()
        {
            string authors = "";
            foreach (string author in Authors)
                authors += author + " ";
            return $"Название книги: {Heading}, Авторы: {authors}, " +
                 $"Цена: {Price} руб.";
        }
    }
}
