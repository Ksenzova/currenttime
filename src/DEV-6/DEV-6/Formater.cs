using System;

namespace DEV_6
{   
    /// <summary>
    /// Form new type of formating date
    /// </summary>           
    class Formater
    {
        public Formater( IFormat form)
        {
            Form= form;
        }
        public IFormat Form { private get; set; }
        public string GetData(DateTime curDate)
        {
            return Form.GetData(curDate);
        }
    }
}
