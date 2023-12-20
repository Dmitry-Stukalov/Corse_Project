namespace Курсовой_проект
{
    class Task
    {
        private string _title;
        private string _description;
        private int _responsible;

        public string Title 
        { 
            get { return _title; }
            set
            {
                if (!string.IsNullOrEmpty(value)) _title = value;
                else throw new ArgumentOutOfRangeException("Task _title cannot be empty");
            }
        }
        public string Description
        {
            get { return _description; }
            set
            {
                if (!string.IsNullOrEmpty(value)) _description = value;
                else throw new ArgumentOutOfRangeException("Task _description cannot be empty");
            }
        }
        public int Responsible
        {
            get { return _responsible; }
            set
            {
                if (value != null) _responsible = value;
                else throw new ArgumentOutOfRangeException("Task _responsible cannot be empty");
            }
        }

        public Task(string title, string description, int responsible)
        {
            Title = title;
            Description = description;
            Responsible = responsible;
        }

        public void Assign_A_Task(Employee new_employee)
        {
            Task new_task = new Task(Title, Description, Responsible);
            new_employee.Get_Task(new_task);
        }
    }
}