namespace Курсовой_проект
{
    class Human
    {
        protected private string _name;
        protected string _surname;
        protected string _patronymic;
        protected int _salary;
        protected int personal_id;

        public string Name
        {
            get { return _name; }
            set
            {
                if (!string.IsNullOrEmpty(value)) _name = value;
                else throw new ArgumentOutOfRangeException("The _name cannot be empty");
            }
        }
        public string Surname
        {
            get { return _surname; }
            set
            {
                if (!string.IsNullOrEmpty(value)) _surname = value;
                else throw new ArgumentOutOfRangeException("The _surname cannot be empty");
            }
        }
        public string Patronymic
        {
            get { return _patronymic; }
            set
            {
                if (!string.IsNullOrEmpty(value)) _patronymic = value;
                else throw new ArgumentOutOfRangeException("The _patronymic cannot be empty");
            }
        }
        public int Salary
        {
            get { return _salary; }
            set
            {
                if (value >= 0) _salary = value;
                else throw new ArgumentOutOfRangeException("The _salary connot be negative");
            }
        }
        public int Personal_ID { get { return personal_id; } set { personal_id = value; } }

        public Human() { }
        public Human(string surname, string name, string patronymic, int salary)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Salary = salary;
        }

        public void Prize(int prize)
        {
            Salary += prize;
        }
    }
}