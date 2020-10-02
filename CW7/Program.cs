/* Name: Enrique Tejeda
 * Date: 10/1/2020
 * Filename: Program.cs
 * Description:
 */

using System;

namespace CW7
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = 1;
            int height = 2;

            Widget w = new TextField(width, height);
            Decorator border = new BorderDecorator(w);
            Decorator scroll = new ScrollDecorator(w);
            Console.WriteLine("W draw");
            w.draw();
            Console.WriteLine("Border draw");
            border.draw();
            Console.WriteLine("Scroll draw");
            scroll.draw();
        }
    }
}