using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_dan_Collection_2
{
    public abstract class karyawan
    {
        public string nik { get; set; }
        public string nama { get; set; }
        public string status { get; set; }

        public abstract double gaji();
    }
}
