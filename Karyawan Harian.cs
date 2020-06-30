using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_dan_Collection_2
{
    public class karyawanharian : karyawan
    {
        public double upahperjam { get; set; }
        public double jumlahjamkerja { get; set; }

        public override double gaji()
        {
            double jumlah = upahperjam * jumlahjamkerja;
            return jumlah;
        }
    }
}
