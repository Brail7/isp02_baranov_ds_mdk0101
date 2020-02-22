using System;


namespace ClassDefinitionTask1
{
    class PCGame
    {
        public string Name{get;set;}
        public string Firm{get;set;}
        public int Year{get;set;}
        public string Genre { get; set; }

        public PCGame(string name, string firm, int year, string genre)
        {
            Name = name;
            Firm = firm;
            Year = year;
            Genre = genre;
        }
        public override string ToString()
        {
            return $"Название игры: {Name}, Компания: {Firm}, " +
                $"Год издания: {Year}, Жанр: {Genre}";
        }

    }
}
