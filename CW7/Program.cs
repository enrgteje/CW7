/* Name: Enrique Tejeda
 * Date: 10/1/2020
 * Filename: Program.cs
 * Description: Program is a test to show that ScrollDecorator, BorderDecorator, and EnlargeDecorator work
 *              using their draw functions. Program also uses Textfield's draw function to show that it works.
 *              The draw function essentially prints to console what type it is.
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
            BorderDecorator border = new BorderDecorator(w);
            ScrollDecorator scroll = new ScrollDecorator(w);
            EnlargeDecorator enlarge = new EnlargeDecorator(w);
            Console.WriteLine("TextField draw");
            w.draw();
            Console.WriteLine("\nBorder draw");
            border.draw();
            Console.WriteLine("\nScroll draw");
            scroll.draw();
            Console.WriteLine("\nEnlarge draw");
            enlarge.draw();
        }
    }
}