using System.Security.Cryptography.X509Certificates;

namespace Курсовой_проект
{
    class Employee: Human
    {
        private Task _task;

        public Task Task
        {
            get { return _task; }
            set { _task = value; }
        }
        
        public Employee()
        {

        }
        public Employee(string surname, string name, string patronymic, int salary, int id): base(surname, name, patronymic, salary)
        {
            Personal_ID = id;
        }

        public void Get_Task(Task task)
        {
            Task = task;
        }

        public string Play_The_Game(ref List_Of_Employees employees, int index, string game)
        {
            Random rand = new Random();
            for (int i = 0; i < rand.Next(3, 8); i++)
            {
                Console.Clear();
                workspace.Write_To_Console($"{Name} играет в {game}.");
                Thread.Sleep(500);
                workspace.Write_To_Console($"{Name} играет в {game}..");
                Thread.Sleep(500);
                workspace.Write_To_Console($"{Name} играет в {game}...");
                Thread.Sleep(1000);
            }
            Console.Clear();

            if (rand.Next(1, 11) > 5) return $"{Name} успешно закончил играть и приступил к выволнению своих задач";
            else
            {
                employees.Delete_Employee(employees.Search_Employee(index));
                employees.ID_Decrement();
                return $"{Name} был замечен за игрой на рабочем месте и уволен";
            }
        }
    }
}