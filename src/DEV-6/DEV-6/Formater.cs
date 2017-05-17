using System;
using static DEV_6.Program;

namespace DEV_6
{   
    /// <summary>
    /// Form new type of formating date
    /// </summary>           
    public class Formater
    {
        public Formater( IFormat form)
        {
            Form= form;
        }
        public IFormat Form { private get; set; }
        public string GetData(DateTime curDate,  Format form)
        {
           return Form.GetData(curDate,form);
        }
    }
}
