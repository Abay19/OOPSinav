using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPSinav
{
    public class Personel
    {
        public string KimlikNo { get; set; }

        public override string ToString()
        {
            return this.KimlikNo;
        }

        public string Ad { get; set; }

        public string Soyad { get; set; }

        public DateTime dogumTarihi { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string Adres { get; set; }
        public DateTime İsGiris { get; set; }
        public string Unvan { get; set; }

        public string ResimYolu { get; set; }
    }

    public enum Departman
    {
        Yazılım,
        Sistem,
        Muhasebe,
        Eğitim,
        İdariİşler,
        OCC,
        AOCC
    }
}