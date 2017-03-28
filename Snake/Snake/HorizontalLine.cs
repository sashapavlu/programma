﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine
    {
        List<Point> plist;

        public HorizontalLine(int xLeft, int xReight, int y, char sym)
        {
            plist = new List<Point>();
            for (int x = xLeft; x <= xReight; x++)
            {
                Point p = new Point(x, y, sym);
                plist.Add(p);
            }
        }
        public void Draw ()
        {
            foreach(Point p in plist)
            {
                p.Draw();
            }
        }
    }
}
