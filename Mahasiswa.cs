﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahasiswa
{
    public class Mahasiswa
    {
        public Mahasiswa()
        {
        }
        public Mahasiswa(string nim, string nama)
        {
            Nim = nim;
            Nama = nama;
        }
        public string Nim { get; set; }
        public string Nama { get; set; }
    }
}
