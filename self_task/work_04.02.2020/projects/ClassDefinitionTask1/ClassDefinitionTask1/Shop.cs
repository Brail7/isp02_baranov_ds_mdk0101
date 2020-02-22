using System;


namespace ClassDefinitionTask1
{
    class Shop
    {

        public string Cipher { get; set; }
        public int AmountOfWorkers { get; set; }

        public Shop(string cipher, int amountOfworkers)
        {
            Cipher = cipher;
            AmountOfWorkers = amountOfworkers;
        }
        public override string ToString()
        {
            return $"Строковый шифр: {Cipher}, " +
                $"Количество работников: {AmountOfWorkers}";
        }
    }

}
