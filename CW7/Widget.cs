/* Name: Enrique Tejeda
 * Date: 10/2/2020
 * Filename: Widget.cs
 * Description: Interface that establishes the draw function so that it will be implemented by
 *              BorderDecorator, ScrollDecorator, EnlargeDecorator, and TextField.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace CW7
{
    public interface Widget
    {
        public  void draw();
    }
}
