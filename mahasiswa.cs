using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latihan1
{
    class mahasiswa
    {
        //properties
        public string NIM { get; set; }
        public string NAMA { get; set; }
        public float IPK { get; set; }
        //menthod
        public void Registrasi()

        {
            Console.WriteLine("NAMA : {0}", NAMA);
            Console.WriteLine("NIM : {0}", NIM);
            Console.WriteLine("IPK : {0}", IPK);
            Console.WriteLine("\n telah melakukan registrasi");

        }
        public void Isikrs()
        {
            Console.WriteLine("{0}sedang melakukan proses krs ", NAMA);
        }
    }

}
    

