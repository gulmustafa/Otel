using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Rezervasyon.Classes
{
    public class Musteri:DbObject
    {
        public Musteri()
        {

        }
        [MaxLength(100)]
        public string Adi { get; set; }
        [MaxLength(100)]
        public string Soyadi { get; set; }
        [MaxLength(100)]
        public string Sifre { get; set; }
        [MaxLength(100)]
        public string KullaniciAdi { get; set; }
        [MaxLength(15)]
        public string TelefonNo { get; set; }
        [MaxLength(100)]
        public string Email { get; set; }
        [MaxLength(11)]
        public string TCNO { get; set; }

        public override string ToString()
        {
            return "Müşteri Bilgileri" +Adi + " " + Soyadi;
        }
    }
}
