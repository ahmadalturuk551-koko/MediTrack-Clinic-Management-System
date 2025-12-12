using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace MeditrackDataAccessLayer
{
    public class Class1
    {
        public static string koko()
        {
            using (OdbcConnection connection = new OdbcConnection("DSN=koko"))
            {
                connection.Open();
                return "State: " + connection.State.ToString();
            }
        }
    }
}
