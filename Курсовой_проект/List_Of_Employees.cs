namespace Курсовой_проект
{
    class List_Of_Employees : List_Human
    {
        private List<Employee> _employees = new List<Employee>();

        public void Add_Employee(Employee new_employee)
        {
            _employees.Add(new_employee);
        }

        public bool Delete_Employee(Employee new_employee) => _employees.Remove(new_employee);

        public Employee Search_Employee(int id)
        {
            for (int i = 0; i < _employees.Count; i++)
            {
                if (_employees[i].Personal_ID == id) return _employees[i];
            }
            Employee null_employee = new Employee("", "", "", 0, -1);
            return null_employee;
       
        }
        public string Show_Employees(int i) => $"{_employees[i].Personal_ID} - {_employees[i].Name} {_employees[i].Surname} {_employees[i].Patronymic} {_employees[i].Salary}. Задача - {_employees[i].Task}";

    }
}