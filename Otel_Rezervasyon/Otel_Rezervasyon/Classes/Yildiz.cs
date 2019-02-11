using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Rezervasyon.Classes
{
    public class Yildiz : DbObject
    {
        public Yildiz()
        {

        }
        public int BegenmeSayisi { get; set; }
        public int BegenmemeSayisi { get; set; }

        public override string ToString()
        {
            return "Memnuniyet Durumu" + BegenmemeSayisi + " "+ BegenmemeSayisi;
        }
    }
}
