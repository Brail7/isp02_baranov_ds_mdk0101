using System;


namespace ClassDefinitionTask1
{
    class Address
    {
        public int Index{get;set;}
        public string City{get;set;}
        public string Street{get;set;}
        public string House{get;set;}
        public int Apartment { get; set; }

        public Address(int index, string city, string street, string house, int apartament)
        {
            Index = index;
            City = city;
            Street = street;
            House = house;
            Apartment = apartament;
        }
        public override string ToString()
        {
            return $"Почтовый индекс: {Index}, Город: {City}, " +
                $"Улица: {Street}, Дом: {House}, Квартира: {Apartment}";
        }

    }
}
