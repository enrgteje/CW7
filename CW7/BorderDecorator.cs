using System;
using System.Collections.Generic;
using System.Text;

namespace CW7
{
    public class BorderDecorator : Decorator
    {
        public BorderDecorator(Widget w) : base(w)
        {

        }
        public void draw()
        {
            Console.WriteLine("This is the BorderDecorator");
        }
    }
}
