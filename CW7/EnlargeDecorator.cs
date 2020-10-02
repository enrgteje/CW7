/* Name: Enrique Tejeda
 * Date: 10/2/2020
 * Filename: EnlargeDecorator.cs
 * Description: Class inherits from the Widget interface. It also implements the draw
 *              function and calls base's draw function as well.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CW7
{
    class EnlargeDecorator : Decorator
    {
        public EnlargeDecorator(Widget w) : base(w) { }
        new public void draw()
        {
            Console.WriteLine("This is the EnlargeDecorator.");
            base.draw();
        }
    }
}
