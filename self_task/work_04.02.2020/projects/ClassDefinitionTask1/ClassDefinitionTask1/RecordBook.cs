using System;


namespace ClassDefinitionTask1
{
    class RecordBook
    {
        public string NameExaminee{get;set;}
        public string NameExaminer{get;set;}
        public int Mark { get; set; }

        public RecordBook(string nameExaminee, string nameExaminer, int mark)
        {
            NameExaminee = nameExaminee;
            NameExaminer = nameExaminer;
            Mark = mark;
        }
        public override string ToString()
        {
            return $"Экзаменуемый: {NameExaminee}, " +
                $"Экзаменатор: {NameExaminer}, Оценка: {Mark}";
        }

    }
}
