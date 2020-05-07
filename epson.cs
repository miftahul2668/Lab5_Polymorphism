using System;
using System.Collections.Generic;
using System.Text;

public class Epson : PrinterWindows
    {
        public override void show()
        {
         Console.WriteLine("Epson Display dimension : 10*11");
        }

        public override void print()
        {
         Console.WriteLine("Epson printer printing ...");
        }
    }