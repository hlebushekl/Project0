using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;


namespace Sotov
{
    public class DataReader
    {
        public static OleDbConnection Connection
        {
            get { return new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=FirstTry.accdb"); }
        }
    }
}
