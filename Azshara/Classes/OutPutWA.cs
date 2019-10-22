using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azshara.Classes
{
    class OutPutWA
    {
        public static void DoWorkOutPut(DataTable dataTable)
        {
            foreach (DataRow record in dataTable.Rows)
            {
                Console.WriteLine(record.ItemArray[0]);
                Console.WriteLine(record.ItemArray[1]);
                Console.WriteLine(record.ItemArray[2]);
                Console.WriteLine(record.ItemArray[3]);
                Console.WriteLine(record.ItemArray[4]);
                Console.WriteLine(record.ItemArray[5]);
            }
        }
    }
}
