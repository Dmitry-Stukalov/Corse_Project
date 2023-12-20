using System.Security;

namespace Курсовой_проект
{
    class Game
    {
        private int _target_audience;
        private string _title;

        public string Title 
        { 
            get { return _title; }
            set 
            {
                if (!string.IsNullOrEmpty(value)) _title = value;
                else throw new ArgumentOutOfRangeException("Game _title cannot be empty");
            }
        }
        public int Target_Audience
        {
            get { return _target_audience; }
            set
            {
                if (value > 0) _target_audience = value;
                else throw new ArgumentOutOfRangeException("Game _target_audience cannot be negative");
            }
        }

        public Game(string title, int target_audience)
        {
            Title = title;
            Target_Audience = target_audience;
        }
    }
}