using System;
using System.Collections.Generic;
using System.Text;

namespace CW7
{
    public class ScrollDecorator : Decorator
    {
        public ScrollDecorator(Widget w) : base(w) { }
        public void draw()
        {
            Console.WriteLine("This is the ScrollDecorator.");
            base.draw();
        }
    }
}
