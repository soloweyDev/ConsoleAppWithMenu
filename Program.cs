using System;

namespace ConsoleAppWithMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            Top top = new Top(new string[] { "Top element" });
            Bottom bottom = new Bottom(new string[] { "Bottom", "element", "next", "previous" });
            string[] text = new string[] { "1 string", "2 string", "3 string" };
            Body body = new Body(text);

            Console.SetWindowPosition(0, 0);
            Console.SetWindowSize(100, 30);
            Console.SetBufferSize(100, 30);
            Console.CursorVisible = false;

            while (true)
            {
                //Console.Clear();
                top.Write();
                bottom.Write();
                body.Write();

                //System.Threading.Thread.Sleep(5000);
            }
        }
    }
}
