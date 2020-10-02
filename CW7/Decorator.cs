/* Name: Enrique Tejeda
 * Date: 10/2/2020
 * Filename: Decorator.cs
 * Description: Class inherits from the Widget interface and establishes a Widget object called wid. This
 *              object is set equal to the argument Widget w in the constructor. Also implements the draw
 *              function and calls wid's draw function as well.
 */

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
