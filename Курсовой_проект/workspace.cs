using System.ComponentModel;
using System.Threading.Tasks;

namespace Курсовой_проект
{
    static class workspace
    {
        public static void Write_To_Console<T>(T str)
        {
            Console.WriteLine(str);
        }

        public static string Read_From_Console() => Console.ReadLine();
        
        public static void Catch_Exception_Employee(ref List_Of_Employees employees)
        {
            workspace.Write_To_Console("\nВведите фамилию, имя, отчество и зарплату нового сотрудника:");
            try
            {
                Employee new_employee = new Employee(Read_From_Console(), Read_From_Console(), Read_From_Console(), Convert.ToInt32(Read_From_Console()), employees.ID);
                employees.Add_Employee(new_employee);
                employees.ID_Increment();
                //write_to_file(new_employee, path);
                Write_To_Console($"\nДанные были добавлены в список сотрудников");
            }
            catch (Exception ex) { Write_To_Console(ex.Message); }
        }

        public static void Catch_Exception_Chiefs(ref List_Of_Chief chiefs)
        {
            workspace.Write_To_Console("\nВведите фамилию, имя, отчество и зарплату нового начальника:");
            try
            {
                Chief new_chief = new Chief(workspace.Read_From_Console(), workspace.Read_From_Console(), workspace.Read_From_Console(), Convert.ToInt32(workspace.Read_From_Console()), chiefs.ID);
                chiefs.Add_Chief(new_chief);
                chiefs.ID_Increment();
                workspace.Write_To_Console("\nДанные были добавлены в список начальников");
            }
            catch (Exception ex) { workspace.Write_To_Console(ex.Message); }
        }

        public static void Catch_Exception_Tasks(ref Task_List tasks, ref List_Of_Employees employees)
        {
            Write_To_Console("\nВведите название, описание и индекс ответственного для нового задания:");
            try
            {
                Task new_task = new Task(Read_From_Console(), Read_From_Console(), Convert.ToInt32(Read_From_Console()));
                tasks.Add_Task(new_task);
                if (employees.Search_Employee(new_task.Responsible).Personal_ID > -1)
                {
                    employees.Search_Employee(new_task.Responsible).Get_Task(new_task);
                }
                else Write_To_Console("Сотрудника с таким индексом не существует");
            }
            catch (Exception ex) { Write_To_Console(ex.Message); }
        }

        public static void Catch_Exception_Games(ref List_Of_Games games)
        {
            Write_To_Console("\nВведите название и возраст целевой аудитории игры игры:");
            try
            {
                Game new_game = new Game(Read_From_Console(), Read_From_Console());
                games.Add_Game(new_game);
                Write_To_Console("Данные были добавлены в список игр");
            }
            catch (Exception ex) { Write_To_Console(ex.Message); }
        }

        public static void Assigning_A_Value(string str, ref int number)
        {
            Write_To_Console(str);
            number = Convert.ToInt32(Read_From_Console());
        }

        public static void Assigning_A_Value(string str, ref string number)
        {
            Write_To_Console(str);
            number = Read_From_Console();
        }

        public static void If_Else(bool check, string _if, string _else)
        {
            if (check) Write_To_Console(_if);
            else Write_To_Console(_else);
        }
    }
}