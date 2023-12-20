namespace Курсовой_проект
{
    class List_Human
    {
        protected int _id = 1;

        public int ID { get { return _id; } set { _id = value; } }

        public void ID_Increment()
        {
            ID++;
        }

        public void ID_Decrement()
        {
            ID--;
        }
    }
}