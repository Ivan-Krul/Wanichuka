using System;
using System.Linq;
using System.Collections.Generic;

namespace Wanichuka
{

    class Map
    {

    }

    class Tail
    {
        private int _x;
        private int _y;
        
        public void Slide(int x,int y)
        {
            _x = x;
            _y = y;
        }

        public int X()
        {
            return _x;
        }

        public int Y()
        {
            return _y;
        }
    }

    class Snake
    {
        private List<Tail> tails = new List<Tail>(1);

        public enum Direction
        {
            up,
            right,
            down,
            left
        } Direction dir;

        public Snake(int start_x,int start_y)
        {
            tails.Add(new Tail());
            dir = Direction.up;
            tails[0].Slide(start_x, start_y);
        }

        public void NewTail()
        {
            tails.Add(new Tail());

            int preview = tails.Count - 1;

            tails[preview].Slide(tails[preview-1].X(), tails[preview - 1].Y());
        }

    }

    

    class Program 
    {
        static void Main() 
        {
            

        }
    }
}
