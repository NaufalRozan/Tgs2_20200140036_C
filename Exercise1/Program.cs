using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Exercise1
{
    class Program
    {
        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=MSI;database=Exercise1;Integrated Security=TRUE");
                con.Open();
            }
        }
    }
}
