using System.Collections.Generic;

namespace Курсовой_проект
{
    class Chief: Human
    {
        public Chief() 
        {
            
        }
        public Chief(string surname, string name, string patronymic, int salary, int id) : base(name, surname, patronymic, salary)
        {
            Personal_ID = id;
        }
    }
}