using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Pair
    {
        public int x { get; private set; }
	    public int y { get; private set; }

        public Pair(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public String toString()
        {
            return "Pair [x=" + x + ", y=" + y + "]";
        }
    }
}
