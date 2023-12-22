namespace Курсовой_проект
{
    class List_Of_Games
    {
        private List<Game> _games = new List<Game>();

        public void Add_Game(Game new_game)
        {
            _games.Add(new_game);
        }

        public int Number_Of_Games() => _games.Count;

        public string Show_Game(int i) => $"название - {_games[i].Title}\tЦелевая аудитория - {_games[i].Target_Audience}\tЗатрачено месяцев на разработку - {_games[i].How_Long_Create}\tЗатрачено денег на разработку - {_games[i].How_Much_Money_Earned}";

        public bool Search_Game(string title)
        {
            for (int i = 0; i < _games.Count; i++)
            {
                if (_games[i].Title == title) return true;
            }
            return false;
        }
    }
}