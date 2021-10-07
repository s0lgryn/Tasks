using System;

namespace i6
{
    public class Countries
    {
        private string name;
        private string capital;
        private string language;
        private int population;
        private string dateOfFoundation;
        private string manager;
        internal string Name { get; set; }
        internal string Capital { get; set; }
        internal string Language { get; set; }
        internal int Population { get; set; }
        internal string DateOfFoundation { get; set; }
        internal string Manager { get; set; }

        public virtual void PrintInfo()
        {
            Console.Write($"Название: {name}\nСтолица: {Capital}\nЯзык: {Language}\nНаселение: {Population}\nДата основания{DateOfFoundation}\nПравитель: {Manager}");
        }
        Countries() { }
        public Countries(string name, string capital, string language, int population, string foundated, string manager)
        {
            this.Name = name;
            this.Capital = capital;
            this.Language = language;
            this.Population = population;
            this.DateOfFoundation = foundated;
            this.Manager = manager;
        }
        public Countries(string name, string capital, int population, string language, string foundated, string manager)
        {
            this.Name = name;
            this.Capital = capital;
            this.Language = language;
            this.Population = population;
            this.DateOfFoundation = foundated;
            this.Manager = manager;
        }
        public Countries(string name, string capital, int population, string language, string foundated)
        {
            this.Name = name;
            this.Capital = capital;
            this.Language = language;
            this.Population = population;
            this.DateOfFoundation = foundated;
            this.Manager = "None";
        }
        public Countries(string name, string capital, int population, string language)
        {
            this.Name = name;
            this.Capital = capital;
            this.Language = language;
            this.Population = population;
            this.DateOfFoundation = "01.01.1900";
            this.Manager = "None";
        }
        public Countries(string name, string capital, int population)
        {
            this.Name = name;
            this.Capital = capital;
            this.Language = "None";
            this.Population = population;
            this.DateOfFoundation = "01.01.1900";
            this.Manager = "None";
        }
        public Countries(string name, string capital)
        {
            this.Name = name;
            this.Capital = capital;
            this.Language = "None";
            this.Population = 0;
            this.DateOfFoundation = "01.01.1900";
            this.Manager = "None";
        }
        public Countries(string name)
        {
            this.Name = name;
            this.Capital = "None";
            this.Language = "None";
            this.Population = 0;
            this.DateOfFoundation = "01.01.1900";
            this.Manager = "None";
        }

    }
    public class Russia : Countries
    {
        private int LevelOfCorruption;
        private int AmountOfBears;
        private int StandartOfLiving;
        public override void PrintInfo()
        {
            Console.Write($"Название: {Name}\nСтолица: {Capital}\nЯзык: {Language}\nНаселение: {Population}\n" +
                $"Дата основания: {DateOfFoundation}\nПравитель: {Manager}\n" +
                $"Уровень коррупции: {LevelOfCorruption}\nКоличество медведей: {AmountOfBears}\nУровень жизни: {StandartOfLiving}");
        }
        public Russia(string name, string capital, string language, int population, string foundated, string manager,
            int corruption, int bears, int livingstandarts)
            : base(name, capital, language, population, foundated, manager)
        {
            this.LevelOfCorruption = corruption;
            this.AmountOfBears = bears;
            this.StandartOfLiving = livingstandarts;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Russia russia = new Russia("Russia","Moscow","Russian",148000000,"01.09.1990","Putin",100,29485,0);
            russia.PrintInfo();
        }
    }
}
