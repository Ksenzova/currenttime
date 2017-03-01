using System;
using static DEV_6.Program;

namespace DEV_6
{
    interface IFormat
    {
        string GetData(DateTime curDate, Format form);
    }
}
