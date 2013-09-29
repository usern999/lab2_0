using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_0
{
    interface Ilogger
    {
        void Log(Severity s, String msg);
        void Indent();
        void Unindent();
    }

    public enum Severity
    {
        Error, Warning, Info
    }
}
