using System;
using static DEV_6.Program;

namespace DEV_6
{
    public interface IFormat
    {
        string GetData(DateTime curDate, Format form);
    }
}
