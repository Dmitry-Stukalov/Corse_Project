using System.ComponentModel.Design;

namespace Курсовой_проект
{
    class Task_List
    {
        private List<Task> _tasks = new List<Task>();

        public void Add_Task(Task new_task)
        {
            _tasks.Add(new_task);
        }

        public void Delete_Task(Task new_task)
        {
            if (new_task.Responsible > 0)
            _tasks.Remove(new_task);
        }

        public Task Search_Task(string title)
        {
            for (int i = 0; i < _tasks.Count; i++)
            {
                if (_tasks[i].Title == title) return _tasks[i];
            }
            Task new_task = new Task(" ", " ", 0);
            return new_task;
        }

        public int Number_Of_Tasks() => _tasks.Count;

        public string Show_Task(int i) => $"\nЗадача:{_tasks[i].Title}\nОписание:{_tasks[i].Description}\nОтветственный:{_tasks[i].Description}";

    }
}