using System;
using System.Linq;
using System.Collections.Generic;

namespace Wanichuka
{
    class Tail
    {
        private int _x;
        private int _y;
        
        public void slide(int x,int y)
        {
            _x = x;
            _y = y;
        }

        public int x()
        {
            return _x;
        }

        public int y()
        {
            return _y;
        }
    }

    class Snake
    {
        private List<Tail> tails = new List<Tail>(1);

        public Snake(int start_x,int start_y)
        {

        }

        public void new_tail()
        {
            tails.Add(new Tail());
            tails.ElementAt(tails.Count - 1).slide(tails.ElementAt(tails.Count-2).x(), tails.ElementAt(tails.Count - 2).y());
        }

    }

    class Program 
    {
        static void Main() 
        {
            

        }
    }
}
