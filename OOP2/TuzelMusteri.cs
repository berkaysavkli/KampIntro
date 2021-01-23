using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    // TuzelMusteri : Musteri  yazımına miras (inheritance) denilir
    // TüzelMusteri bir Musteri dir demektir.
    class TuzelMusteri:Musteri
    {
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
