using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responsi
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan karyawan = new Karyawan( 190302123, "Paijo", 3000000);
            Karyawan karyawan2 = new Karyawan(190302124, "Jono", 2000000);
            

            Console.WriteLine("No Nik\t    Nama\t  GajiBulanan");
            Console.WriteLine("-------------------------------------------");
            karyawan.karyawan();
            karyawan2.karyawan();
            

            Console.WriteLine("\n\nAseekkkk Kenaikan Gaji 10%!!!\n\n");

            Console.WriteLine("No Nik\t    Nama\t  GajiBulanan");
            Console.WriteLine("-------------------------------------------");
            karyawan.NaikGaji();
            karyawan2.NaikGaji();
            
            Console.ReadKey();
        }
    }
}
