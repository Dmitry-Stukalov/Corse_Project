using System.Diagnostics.CodeAnalysis;
using System.Security;

namespace Курсовой_проект
{
    class Game
    {
        private int _target_audience;
        private string _title;
        private int _how_long_create;
        private int _how_much_money_earned;

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
        public int How_Long_Create
        {
            get { return _how_long_create; }
            set
            {
                if (value > 0) _how_long_create = value;
                else throw new ArgumentOutOfRangeException("Game _how_long_create cannot be empty");
            }
        }
        public int How_Much_Money_Earned
        {
            get { return _how_much_money_earned; }
            set
            {
                if (value >= 0) _how_much_money_earned = value;
                else throw new ArgumentOutOfRangeException("Game _how_much_money_earned cannot be empty");
            }
        }

        public Game(string title, int target_audience, int how_long_create, int how_much_money_earned)
        {
            Title = title;
            Target_Audience = target_audience;
            How_Long_Create = how_long_create;
            How_Much_Money_Earned = how_much_money_earned;
        }
    }
}