using System;


namespace ClassDefinitionTask1
{
    class Notes
    {
        public string SerialAndNumber{get;set;}
        public int Denomination{get;set;}
        public string DenominationToString { get; set; }

       public Notes(string serialAndNumber, int denomination,string denominationToString)
        {
            SerialAndNumber = serialAndNumber;
            Denomination = denomination;
            DenominationToString = denominationToString;
        }
        public override string ToString()
        {
            return $"Серия и номер: {SerialAndNumber}, " +
                $"Номинал: {Denomination} руб., " +
                $"Номинал прописью: {DenominationToString} руб.";
        }

    }
}
