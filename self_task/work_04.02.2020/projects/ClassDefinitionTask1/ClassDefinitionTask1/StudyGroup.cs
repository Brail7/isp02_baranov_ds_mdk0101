using System;


namespace ClassDefinitionTask1
{
    class StudyGroup
    {
        public int Cipher{get;set;}
        public string Specialty{get;set;}
        public int Quantity{get;set;}
        public int YearOfFormation { get; set; }

        public StudyGroup(int cipher, string speciality, int quanity, int yearOfFormation)
        {
            Cipher = cipher;
            Specialty = speciality;
            Quantity = quanity;
            YearOfFormation = yearOfFormation;
        }
        public override string ToString()
        {
            return $"Шифр: {Cipher}, Специальность: {Specialty}," +
                $" Количество студентов: {Quantity}," +
                $" Год формирования: {YearOfFormation} год.";
        }

    }
}
