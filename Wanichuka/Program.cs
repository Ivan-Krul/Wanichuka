using System;
using System.Linq;
using System.Collections.Generic;

namespace Wanichuka
{

    class Map
    {
        private char[,] _plate;
        private int _x;
        private int _y;

        public Map(int x,int y)
        {
            _x = x;
            _y = y;

            _plate=new char[_x,_y];
        }

        public void Insert(int x,int y, char ch)
        {
            if (-1 < x && x < _x && -1 < y && y < _y) _plate[x, y] = ch;
        }

        public char PullOut(int x,int y)
        {
            if (-1 < x && x < _x && -1 < y && y < _y) return _plate[x, y];
            else return '\0';
        }

        public void WriteOut()
        {
            string stroke="";
            for (int i = 0; i < _y; i++)
            {
                for (int j = 0; j < _x; j++)
                {
                    stroke += _plate[j, i];
                }
            }
            Console.WriteLine(stroke);

        }

    }

    
    class Snake
    {
        private class Tail
        {
            private int _x;
            private int _y;

            public void Slide(int x, int y)
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

        private List<Tail> tails = new List<Tail>(1);

        public enum Direction
        {
            up,
            right,
            down,
            left
        } 
        private Direction dir;

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
