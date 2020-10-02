/* Name: Enrique Tejeda
 * Date: 10/2/2020
 * Filename: Textfield.cs
 * Description: Class implements the draw function as well as make 2 member variables. Both variables are set
 *              equal to the arguments in the constructor.
 */

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
        }

        public TextField(int w, int h)
        {
            width = w;
            height = h;
        }
    }
}
