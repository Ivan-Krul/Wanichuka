using System;
using System.Collections.Generic;

namespace Wanichuka
{
    class Program 
    {
        static void Main() 
        {
            int x = 16, y = 8;
            int[,] map = new int[x, y];

            ///////////////////////////
            
            List<int> zaglushka = new List<int>();
            zaglushka.Add(x / 2);
            zaglushka.Add(y / 2);

            List<List<int>> snake=new List<List<int>>();

            snake.Add(zaglushka);

            ///////////////////////////

            while (true)
            {
                
            }

        }
    }
}
