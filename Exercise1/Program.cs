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

                SqlCommand ksr = new SqlCommand("create table Kasir (Id_Kasir char(5) Primary Key," + "Nama_Kasir varchar(25), Kassa varchar(2))", con);
            }
        }
    }
}
