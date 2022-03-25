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
                con = new SqlConnection("data source=MSI;database=TGS2PABD;Integrated Security=TRUE");
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

        public void InsertData()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=MSI;database=TGS2PABD;Integrated Security=TRUE");
                con.Open();

                SqlCommand ksr = new SqlCommand("insert into Kasir (Id_Kasir, Nama_Kasir, Kassa)" + "values('KSR09','Naufal','1')", con);
                ksr.ExecuteNonQuery();

                SqlCommand ksr1 = new SqlCommand("insert into Kasir (Id_Kasir, Nama_Kasir, Kassa)" + "values('KSR02','Rozan','1')", con);
                ksr1.ExecuteNonQuery();

                SqlCommand ksr2 = new SqlCommand("insert into Kasir (Id_Kasir, Nama_Kasir, Kassa)" + "values('KSR03','Bila','2')", con);
                ksr2.ExecuteNonQuery();

                SqlCommand ksr3 = new SqlCommand("insert into Kasir (Id_Kasir, Nama_Kasir, Kassa)" + "values('KSR04','Adit','3')", con);
                ksr3.ExecuteNonQuery();

                SqlCommand ksr4 = new SqlCommand("insert into Kasir (Id_Kasir, Nama_Kasir, Kassa)" + "values('KSR05','Budi','3')", con);
                ksr4.ExecuteNonQuery();


                SqlCommand pbl = new SqlCommand("insert into Pembeli (Id_Pembeli, Nama_Pembeli, Telepon_Pembeli)" + "values('PBL01','Pablo','083278238820')", con);
                pbl.ExecuteNonQuery();

                SqlCommand pbl1 = new SqlCommand("insert into Pembeli (Id_Pembeli, Nama_Pembeli, Telepon_Pembeli)" + "values('PBL02','Hotman','0837898238820')", con);
                pbl1.ExecuteNonQuery();

                SqlCommand pbl2 = new SqlCommand("insert into Pembeli (Id_Pembeli, Nama_Pembeli, Telepon_Pembeli)" + "values('PBL03','Paris','0832782989820')", con);
                pbl2.ExecuteNonQuery();

                SqlCommand pbl3 = new SqlCommand("insert into Pembeli (Id_Pembeli, Nama_Pembeli, Telepon_Pembeli)" + "values('PBL04','Alex','083278236760')", con);
                pbl3.ExecuteNonQuery();

                SqlCommand pbl4 = new SqlCommand("insert into Pembeli (Id_Pembeli, Nama_Pembeli, Telepon_Pembeli)" + "values('PBL05','Sara','083278455430')", con);
                pbl4.ExecuteNonQuery();


                SqlCommand brg = new SqlCommand("insert into Barang (Kode_Barang, Nama_Barang, Harga_Barang, Jumlah_Barang)" + "values('BL001', 'Bolu', '30000','3')", con);
                brg.ExecuteNonQuery();

                SqlCommand brg1 = new SqlCommand("insert into Barang (Kode_Barang, Nama_Barang, Harga_Barang, Jumlah_Barang)" + "values('BF001', 'Black Forest', '45000','2')", con);
                brg1.ExecuteNonQuery();

                SqlCommand brg2 = new SqlCommand("insert into Barang (Kode_Barang, Nama_Barang, Harga_Barang, Jumlah_Barang)" + "values('RV201', 'Red Velvet', '20000','5')", con);
                brg2.ExecuteNonQuery();

                SqlCommand brg3 = new SqlCommand("insert into Barang (Kode_Barang, Nama_Barang, Harga_Barang, Jumlah_Barang)" + "values('CR539', 'Croffle', '15000','3')", con);
                brg3.ExecuteNonQuery();

                SqlCommand brg4 = new SqlCommand("insert into Barang (Kode_Barang, Nama_Barang, Harga_Barang, Jumlah_Barang)" + "values('PI021', 'Pie', '40000','10')", con);
                brg4.ExecuteNonQuery();


                SqlCommand trk = new SqlCommand("insert into Transaksi (Kode_Transaksi, Tanggal, Waktu)" + "values('TRK01','2022-01-01','02:35:00')", con);
                trk.ExecuteNonQuery();

                SqlCommand trk1 = new SqlCommand("insert into Transaksi (Kode_Transaksi, Tanggal, Waktu)" + "values('TRK02','2022-02-24','04:35:00')", con);
                trk1.ExecuteNonQuery();
                
                SqlCommand trk2 = new SqlCommand("insert into Transaksi (Kode_Transaksi, Tanggal, Waktu)" + "values('TRK03','2022-01-24','01:35:00')", con);
                trk2.ExecuteNonQuery();

                SqlCommand trk3 = new SqlCommand("insert into Transaksi (Kode_Transaksi, Tanggal, Waktu)" + "values('TRK04','2022-03-24','11:32:00')", con);
                trk3.ExecuteNonQuery();

                SqlCommand trk4 = new SqlCommand("insert into Transaksi (Kode_Transaksi, Tanggal, Waktu)" + "values('TRK05','2021-08-24','10:35:00')", con);
                trk4.ExecuteNonQuery();

                Console.WriteLine("Data Berhasil di Input...");
                Console.ReadKey();
            }catch(Exception e)
            {
                Console.WriteLine("Gagal Menginput Data..." + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }
        }

        static void Main(string[] args)
        {
            //new Program().CreateTable();
            new Program().InsertData();
        }
    }
}
