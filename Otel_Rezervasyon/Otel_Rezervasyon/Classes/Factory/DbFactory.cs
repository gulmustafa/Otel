using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otel_Rezervasyon.Classes
{

    //Her yere yazmak yerine bir yere yazıp kullanmak -> Factory Design Pattern
    public static class DbFactory
    {
        //Birden fazla kez üretilmesini engellemek için ->Singleton
        private static volatile OtelContext _db = null;
        public static OtelContext Db
        {
            get
            {
                if (_db == null)
                {
                    _db = new OtelContext();
                }
                return _db;
            }
        }

        //İlCrud
        private static volatile GenelCrud<İl> _ilCrud = null;
        public static GenelCrud<İl> İlCrud
        {
            get
            {
                if (_ilCrud == null)
                {
                    _ilCrud= new GenelCrud<İl>(Db, Db.İller);
                }
                return _ilCrud;
            }
        }
        //İlceCrud
        private static volatile GenelCrud<İlce> _ilceCrud = null;
        public static GenelCrud<İlce> İlceCrud
        {
            get
            {
                if (_ilceCrud == null)
                {
                    _ilceCrud = new GenelCrud<İlce>(Db, Db.İlceler);
                }
                return _ilceCrud;
            }
        }
        //MahalleCrud
        private static volatile GenelCrud<Mahalle> _mahalleCrud = null;
        public static GenelCrud<Mahalle> MahalleCrud
        {
            get
            {
                if (_mahalleCrud == null)
                {
                    _mahalleCrud = new GenelCrud<Mahalle>(Db, Db.Mahalleler);
                }
                return _mahalleCrud;
            }
        }
        //MusteriCrud
        private static volatile GenelCrud<Musteri> _musteriCrud = null;
        public static GenelCrud<Musteri> MusteriCrud
        {
            get
            {
                if (_musteriCrud == null)
                {
                    _musteriCrud = new GenelCrud<Musteri>(Db, Db.Musteriler);
                }
                return _musteriCrud;
            }
        }
        //OdaCrud
        private static volatile GenelCrud<Oda> _odaCrud = null;
        public static GenelCrud<Oda> OdaCrud
        {
            get
            {
                if (_odaCrud == null)
                {
                    _odaCrud = new GenelCrud<Oda>(Db, Db.Odalar);
                }
                return _odaCrud;
            }
        }
        //OtelCrud
        private static volatile GenelCrud<Otel> _otelCrud = null;
        public static GenelCrud<Otel> OtelCrud
        {
            get
            {
                if (_otelCrud == null)
                {
                    _otelCrud = new GenelCrud<Otel>(Db, Db.Oteller);
                }
                return _otelCrud;
            }
        }

        //OtelResimCrud
        private static volatile GenelCrud<OtelResimleri> _resimCrud = null;
        public static GenelCrud<OtelResimleri> ResimCrud
        {
            get
            {
                if (_resimCrud == null)
                {
                    _resimCrud = new GenelCrud<OtelResimleri>(Db, Db.Resimler);
                }
                return _resimCrud;
            }
        }

        //OzellikCrud
        private static volatile GenelCrud<Ozellik> _ozellikCrud = null;
        public static GenelCrud<Ozellik> OzellikCrud
        {
            get
            {
                if (_ozellikCrud == null)
                {
                    _ozellikCrud = new GenelCrud<Ozellik>(Db, Db.Ozellikler);
                }
                return _ozellikCrud;
            }
        }

        //RezervasyonCrud
        private static volatile GenelCrud<Rezervasyon> _rezervasyonCrud = null;
        public static GenelCrud<Rezervasyon> RezervasyonCrud
        {
            get
            {
                if (_rezervasyonCrud == null)
                {
                    _rezervasyonCrud = new GenelCrud<Rezervasyon>(Db, Db.Rezervasyonlar);
                }
                return _rezervasyonCrud;
            }
        }

        //YildizCrud
        private static volatile GenelCrud<Yildiz> _yildizCrud = null;
        public static GenelCrud<Yildiz> YildizCrud
        {
            get
            {
                if (_yildizCrud == null)
                {
                    _yildizCrud = new GenelCrud<Yildiz>(Db, Db.Yildizlar);
                }
                return _yildizCrud;
            }
        }

        //YorumCrud
        private static volatile GenelCrud<Yorum> _yorumCrud = null;
        public static GenelCrud<Yorum> YorumCrud
        {
            get
            {
                if (_yorumCrud == null)
                {
                    _yorumCrud = new GenelCrud<Yorum>(Db, Db.Yorumlar);
                }
                return _yorumCrud;
            }
        }




    }
}

