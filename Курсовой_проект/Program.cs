using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace Курсовой_проект
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int index = -1;
            int prize = -1;
            int number;
            int number_employee;
            int number_chief;
            int number_task;
            int number_game;
            string name = "";


            List_Of_Employees employees = new List_Of_Employees();
            List_Of_Chief chiefs = new List_Of_Chief();
            Task_List tasks = new Task_List();
            List_Of_Games games = new List_Of_Games();


            workspace.Write_To_Console("Добро пожаловать в систему учета сотрудников, их начальников, а также задач в вашей компании!!!");

            do
            {
                workspace.Write_To_Console("\nДля работы с сотрудниками - нажмите 1\nДля работы с начальниками - нажмите 2\nДля работы с задачами - нажмите 3\nДля работы с играми - нажмите 4\nДля выхода из системы - нажмите 0");
                number = Convert.ToInt32(Console.ReadLine());


                if (number == 1)
                {
                    workspace.Write_To_Console("\nРабота с сотрудниками:");
                    workspace.Write_To_Console("Для добавления нового сотрудника - нажмите 1\nДля удаления сотрудника - нажмите 2\nДля поиска сотрудника по индексу - нажмите 3\nДля вручения премии сотруднику - нажмите 4\nДля вывода всего списка сотрудников - нажмите 5\nДля запуска игры - нажмите 6");

                    number_employee = Convert.ToInt32(workspace.Read_From_Console());

                    if (number_employee == 1)
                    {
                        workspace.Catch_Exception_Employee(ref employees);
                    }

                    if (number_employee == 2)
                    {
                        workspace.Assigning_A_Value("\nВведите личный индекс сотрудника, которого хотите удалить:", ref index);
                        workspace.If_Else(employees.Delete_Employee(employees.Search_Employee(index)), "Сотрудник был успешно удален", "Сотрудника с таким индексом не существует");
                    }

                    if (number_employee == 3)
                    {
                        workspace.Assigning_A_Value("\nВведите личный индекс сотрудника, которого хотите хотите найти:", ref index);
                        Employee new_employee = new Employee();
                        new_employee = employees.Search_Employee(index);
                        if (new_employee.Personal_ID == -1) workspace.Write_To_Console("Такого сотрудника не существует");
                        else workspace.Write_To_Console($"Индекс - {employees.Search_Employee(index).Personal_ID}\tДанные - {employees.Search_Employee(index).Name} {employees.Search_Employee(index).Surname} {employees.Search_Employee(index).Patronymic} {employees.Search_Employee(index).Salary}");
                    }

                    if (number_employee == 4)
                    {
                        workspace.Assigning_A_Value("\nВведите индекс сотрудника:", ref index);
                        workspace.Assigning_A_Value("Введите размер премии", ref prize);
                        employees.Search_Employee(index).Prize(prize);
                    }

                    if (number_employee == 5)
                    {
                        workspace.Write_To_Console("\nСписок сотрудников:");
                        for (int i = 0; i < employees.ID - 1; i++)  workspace.Write_To_Console(employees.Show_Employees(i));
                    }

                    if (number_employee == 6)
                    {
                        workspace.Assigning_A_Value("\nВведите индекс сотрудника, который сядет играть:", ref index);
                        workspace.Assigning_A_Value("Введите название игры, в которую он будет играть:", ref name);
                        if (games.Search_Game(name))
                        {
                            workspace.If_Else(employees.Search_Employee(index).Personal_ID > 0, employees.Search_Employee(index).Play_The_Game(ref employees, index, name), "Сотрудника с таким индексом не существует");
                        }
                        else workspace.Write_To_Console("Игры с таким названием не существует");

                    }
                }



                if (number == 2)
                {
                    workspace.Write_To_Console("\nРабота с начальниками:");
                    workspace.Write_To_Console("Для добавления нового начальника - нажмите 1\nДля удаления начальника - нажмите 2\nДля поиска начальника по индексу - нажмите 3\nДля вручения премии начальнику - нажмите 4\nДля вывода всего списка начальников - нажмите 5");

                    number_chief = Convert.ToInt32(workspace.Read_From_Console());

                    if (number_chief == 1)
                    {
                        workspace.Catch_Exception_Chiefs(ref chiefs);
                    }

                    if (number_chief == 2)
                    {
                        workspace.If_Else(chiefs.Delete_Chief(chiefs.Search_Chief(index)), "Начальник был успешно удален", "Начальника с таким индексом не существует");
                    }

                    if (number_chief == 3)
                    {
                        workspace.Assigning_A_Value("\nВведите личный индекс начальника, которого хотите хотите найти:", ref index);
                        Chief new_chief = new Chief();
                        new_chief = chiefs.Search_Chief(index);
                        if (new_chief.Personal_ID == -1) workspace.Write_To_Console("Такого начальника не существует");
                        else workspace.Write_To_Console($"Индекс - {chiefs.Search_Chief(index).Personal_ID}\tДанные - {chiefs.Search_Chief(index).Name} {chiefs.Search_Chief(index).Surname} {chiefs.Search_Chief(index).Patronymic} {chiefs.Search_Chief(index).Salary}");
                    }

                    if (number_chief == 4)
                    {
                        workspace.Assigning_A_Value("\nВведите индекс начальника:", ref index);
                        workspace.Assigning_A_Value("Введите размер премии", ref prize);
                        chiefs.Search_Chief(index).Prize(prize);
                    }

                    if (number_chief == 5)
                    {
                        workspace.Write_To_Console("\nСписок начальников:");
                        for (int i = 0; i < chiefs.ID - 1; i++) workspace.Write_To_Console(chiefs.Show_Chiefs(i));
                    }
                }



                if (number == 3)
                {
                    workspace.Write_To_Console("\nРабота с задачами:");
                    workspace.Write_To_Console("Для добавления новой задачи - нажмите 1\nДля удаления задачи - нажмите 2\nДля вывода списка задач - нажмите 3");

                    number_task = Convert.ToInt32(workspace.Read_From_Console());

                    if (number_task == 1)
                    {
                        workspace.Catch_Exception_Tasks(ref tasks, ref employees);
                    }

                    if (number_task == 2)
                    {
                        workspace.Write_To_Console("\nВведите название задачи, которую хотите удалить:");
                        tasks.Delete_Task(tasks.Search_Task(workspace.Read_From_Console()));
                        workspace.Write_To_Console("Задача была успешно удалена");
                    }

                    if (number_task == 3)
                    {
                        workspace.Write_To_Console("\nСписок задач:");
                        for (int i = 0; i < tasks.Number_Of_Tasks(); i++) workspace.Write_To_Console(tasks.Show_Task(i));
                    }
                }


                if (number == 4)
                {
                    workspace.Write_To_Console("\nРабота с играми:");
                    workspace.Write_To_Console("Для добавления новой игры - нажмите 1\nДля вывода списка игр - нажмите 2\n");

                    number_game = Convert.ToInt32(workspace.Read_From_Console());

                    if (number_game == 1)
                    {
                        workspace.Catch_Exception_Games(ref games);
                    }

                    if (number_game == 2)
                    {
                        workspace.Write_To_Console("\nСписок игр:");
                        for (int i = 0; i < games.Number_Of_Games(); i++) workspace.Write_To_Console(games.Show_Game(i));
                    }
                }
                
            } while (number == 1 || number == 2 || number == 3 || number == 4);
        }
    }
}