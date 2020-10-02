using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace CW7
{
    public class TextField : Widget
    {
        private int width;
        private int height;
        public void draw()
        {
            Console.WriteLine("This is the TextField.");

            // OR THIS IMPLEMENTATION

            /*Console.WriteLine("The width of the TextField is " + width +
                "\nThe height of the Textfield is " + height);*/
        }

        public TextField(int w, int h)
        {
            /*Console.WriteLine("The width of the TextField is " + w + 
                "\nThe height of the Textfield is " + h);*/

            //or this implementation

            width = w;
            height = h;
        }
    }
}
