using System;
using System.Collections.Generic;
using System.Text;

namespace CW7
{
    public abstract class Decorator : Widget
    {
        private Widget wid;
        public Decorator(Widget w)
        {
            wid = w;
        }
        public void draw()
        {
            Console.WriteLine("This is the Decorator.");
            wid.draw();
        }
    }
}
