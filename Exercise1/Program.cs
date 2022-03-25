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
                ksr.ExecuteNonQuery();

                SqlCommand pbl = new SqlCommand("create table Pembeli (Id_Pembeli char(5) Primary Key," + "Nama_Pembeli varchar(25), Telepon_Pembeli varchar(13))", con);
                pbl.ExecuteNonQuery();

                SqlCommand brg = new SqlCommand("create table Barang (Kode_Barang char(5) Primary Key," + "Nama_Barang varchar(20), Harga_Barang int, Jumlah_Barang int)", con);
                brg.ExecuteNonQuery();

                SqlCommand trk = new SqlCommand("create table Transaksi (Kode_Transaksi char(5) Primary Key," + "Id_Kasir char(5) foreign key references Kasir(Id_Kasir), Id_Pembeli char(5) foreign key references Pembeli(Id_Pembeli), Kode_Barang char(5) foreign key references Barang(Kode_Barang), Tanggal date, Waktu time)", con);
                trk.ExecuteNonQuery();

                Console.WriteLine("Table Berhasil Dibuat...");
                Console.ReadKey();

            } catch (Exception e)
            {
                Console.WriteLine("Gagal Membuat Tabel..." + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }
        }
    }
}
