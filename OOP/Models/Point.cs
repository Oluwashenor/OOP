using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Models
{
    public class Point
    {
        private int x;
        private int y;

        public int X { get; set; }
        public int Y {
            get
            {
                return y;
            }
            set
            {
                y = value;
            } 
        }

        public Point()
        {

        }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
