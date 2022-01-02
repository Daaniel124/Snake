using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class HorizontalLine
    {
        List<Point> pList;

        public HorizontalLine(int xLeft, int XReight, int y, char sym)
        {
            pList = new List<Point>();
            for(int x = xLeft; x <= XReight; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
            
        }

        public void Drow()
        {
            foreach(Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
