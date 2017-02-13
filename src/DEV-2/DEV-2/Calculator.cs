using System;
using System.Data;


namespace DEV_2
{
    // Calculate correct mathematical expression
    class Calculator
    {
        // Calculate and then output result
        public void calculate(string data)
        {
            DataTable data_table = new DataTable();
            var result = data_table.Compute(data, "");
            Console.WriteLine(result);
        }
    }
}
