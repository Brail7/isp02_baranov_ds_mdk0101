using System;

namespace ClassDefinitionTask1
{
    class Worker
    {
        public string Name{ get; set; }
        public string Profession{get; set;}
        public int Skill{get; set;}

        public Worker(string name, string profession, int skill)
        {
            Name = name;
            Profession = profession;
            Skill = skill;
        }
        public override string ToString()
        {
            return $"Имя: {Name}: Профессия {Profession}, " +
                $"Рабочий стаж: {Skill} лет";
        }
    }

}
