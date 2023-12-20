namespace Курсовой_проект
{
    class List_Of_Chief: List_Human
    {
        private List<Chief> _chiefs = new List<Chief>();

        public void Add_Chief(Chief new_chief)
        {
            _chiefs.Add(new_chief);
        }

        public bool Delete_Chief(Chief new_chief) => _chiefs.Remove(new_chief);

        public Chief Search_Chief(int id)
        {
            for (int i = 0; i < _chiefs.Count; i++)
            {
                if (_chiefs[i].Personal_ID == id) return _chiefs[i];
            }
            Chief null_chief = new Chief("", "", "", 0, -1);
            return null_chief;
        }

        public string Show_Chiefs(int i) => $"{_chiefs[i].Personal_ID} - {_chiefs[i].Name} {_chiefs[i].Surname} {_chiefs[i].Patronymic} {_chiefs[i].Salary}";

    }
}