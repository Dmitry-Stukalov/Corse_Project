using System.Collections.Generic;

namespace Курсовой_проект
{
    class Chief: Human
    {
        private string _name;
        private string _surname;
        private string _patronymic;
        private int _salary;
        private int personal_id;

        public override string Name
        {
            get { return _name; }
            set
            {
                if (!string.IsNullOrEmpty(value)) _name = value;
                else throw new ArgumentOutOfRangeException("The _name cannot be empty");
            }
        }
        public override string Surname
        {
            get { return _surname; }
            set
            {
                if (!string.IsNullOrEmpty(value)) _surname = value;
                else throw new ArgumentOutOfRangeException("The _surname cannot be empty");
            }
        }
        public override string Patronymic
        {
            get { return _patronymic; }
            set
            {
                if (!string.IsNullOrEmpty(value)) _patronymic = value;
                else throw new ArgumentOutOfRangeException("The _patronymic cannot be empty");
            }
        }
        public override int Salary
        {
            get { return _salary; }
            set
            {
                if (value >= 0) _salary = value;
                else throw new ArgumentOutOfRangeException("The _salary connot be negative");
            }
        }
        public override int Personal_ID { get { return personal_id; } set { personal_id = value; } }

        public Chief() 
        {
            
        }
        public Chief(string surname, string name, string patronymic, int salary, int id) : base(name, surname, patronymic, salary)
        {
            Personal_ID = id;
        }

        public void Prize(int prize)
        {
            Salary += prize;
        }
    }
}