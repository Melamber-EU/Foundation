using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azshara.Classes
{
    class SQLiteF
    {
        public static DataTable ReadRosterFromDB(string fullPath, string sqlQuery)
        {
            SQLiteConnection sqlite_conn = new SQLiteConnection();
            sqlite_conn = new SQLiteConnection("Data Source=" + fullPath + ";Version=3;New=False;Compress=True;");
            DataTable dtRoster = new DataTable();
            try
            {
                sqlite_conn.Open();
                SQLiteCommand command = sqlite_conn.CreateCommand();
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);

                command.CommandText = sqlQuery;
                adapter.Fill(dtRoster);
                sqlite_conn.Close();
                foreach (DataRow row in dtRoster.Rows)
                {
                    Console.WriteLine(row.ItemArray[1].ToString());
                }
            }
            catch (Exception ex)
            {

            }
            return dtRoster;
        }

    }
}
