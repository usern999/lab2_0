using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_0
{
    public class Consolelogger : Ilogger
    {
        private Int32 number = 0;
        public void Log(Severity s, String msg)
        {
            switch (s)
            {
                case Severity.Error:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case Severity.Warning:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case Severity.Info:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
            }
            for (int i = 0; i < number; ++i)
            {
                Console.Write(" ");
            }
            Console.WriteLine(msg);

        }

        public void Indent()
        {
            number += 2;
        }

        public void Unindent()
        {
            if (number != 0)
            {
                number -= 2;
            }
        }
    }
}
