using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE_PABD
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Connecting();
        }

        public void Connecting()//membuat koneksi
        {
            using (
                SqlConnection con = new SqlConnection("data source=LENOVO\\AKMALAMRAN;database=akmal_exe2;User ID=sa;Password=uzumaki")
                )
            {
                con.Open();
                Console.WriteLine("Berhasil terhubung ke database!");
            }

        }
    }
}
