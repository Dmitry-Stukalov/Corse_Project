namespace Курсовой_проект
{
    abstract class Human
    {
        abstract public string Name { get; set; }
        abstract public string Surname { get; set; }
        abstract public string Patronymic { get; set; }
        abstract public int Salary { get; set; }
        abstract public int Personal_ID { get; set; }

        public Human() { }
        public Human(string surname, string name, string patronymic, int salary)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Salary = salary;
        }
    }
}