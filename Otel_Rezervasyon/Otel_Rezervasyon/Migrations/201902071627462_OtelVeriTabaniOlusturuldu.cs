namespace Otel_Rezervasyon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OtelVeriTabaniOlusturuldu : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.İlce",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        İlceAdi = c.String(),
                        OlusturanKisi = c.String(),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(),
                        İl_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.İl", t => t.İl_Id)
                .Index(t => t.İl_Id);
            
            CreateTable(
                "dbo.Mahalles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        MahalleAdi = c.String(),
                        OlusturanKisi = c.String(),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(),
                        İlce_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.İlce", t => t.İlce_Id)
                .Index(t => t.İlce_Id);
            
            CreateTable(
                "dbo.İl",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        İlAdi = c.String(),
                        OlusturanKisi = c.String(),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Musteris",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Adi = c.String(),
                        Soyadi = c.String(),
                        Sifre = c.String(),
                        KullaniciAdi = c.String(),
                        TelefonNo = c.String(),
                        Email = c.String(),
                        TCNO = c.String(),
                        OlusturanKisi = c.String(),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Odas",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Ucret = c.Double(nullable: false),
                        odaTipi = c.Int(nullable: false),
                        BosMu = c.Boolean(nullable: false),
                        OdaNo = c.String(),
                        OlusturanKisi = c.String(),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(),
                        Otel_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Otels", t => t.Otel_Id)
                .Index(t => t.Otel_Id);
            
            CreateTable(
                "dbo.Otels",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Adi = c.String(),
                        VergiNo = c.String(),
                        ResmiAdi = c.String(),
                        Aciklama = c.String(),
                        OlusturanKisi = c.String(),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(),
                        Adresi_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.İl", t => t.Adresi_Id)
                .Index(t => t.Adresi_Id);
            
            CreateTable(
                "dbo.Yildizs",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        BegenmeSayisi = c.Int(nullable: false),
                        BegenmemeSayisi = c.Int(nullable: false),
                        OlusturanKisi = c.String(),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(),
                        Otel_Id = c.String(maxLength: 128),
                        Yorum_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Otels", t => t.Otel_Id)
                .ForeignKey("dbo.Yorums", t => t.Yorum_Id)
                .Index(t => t.Otel_Id)
                .Index(t => t.Yorum_Id);
            
            CreateTable(
                "dbo.Yorums",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        YorumBasligi = c.String(),
                        YorumIcerigi = c.String(),
                        OlusturanKisi = c.String(),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(),
                        Musteri_Id = c.String(maxLength: 128),
                        Otel_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Musteris", t => t.Musteri_Id)
                .ForeignKey("dbo.Otels", t => t.Otel_Id)
                .Index(t => t.Musteri_Id)
                .Index(t => t.Otel_Id);
            
            CreateTable(
                "dbo.Ozelliks",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        OzellikAdi = c.String(),
                        OlusturanKisi = c.String(),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OtelResimleris",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Resim = c.Binary(),
                        OlusturanKisi = c.String(),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(),
                        Otel_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Otels", t => t.Otel_Id)
                .Index(t => t.Otel_Id);
            
            CreateTable(
                "dbo.Rezervasyons",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        KisiSayisi = c.String(),
                        CheckDate = c.DateTime(nullable: false),
                        CheckOutDate = c.DateTime(nullable: false),
                        OdemeZamani = c.Int(nullable: false),
                        OlusturanKisi = c.String(),
                        OlusturmaTarihi = c.DateTime(nullable: false),
                        GuncellemeTarihi = c.DateTime(nullable: false),
                        GuncelleyenKisi = c.String(),
                        Musteri_Id = c.String(maxLength: 128),
                        Oda_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Musteris", t => t.Musteri_Id)
                .ForeignKey("dbo.Odas", t => t.Oda_Id)
                .Index(t => t.Musteri_Id)
                .Index(t => t.Oda_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rezervasyons", "Oda_Id", "dbo.Odas");
            DropForeignKey("dbo.Rezervasyons", "Musteri_Id", "dbo.Musteris");
            DropForeignKey("dbo.OtelResimleris", "Otel_Id", "dbo.Otels");
            DropForeignKey("dbo.Odas", "Otel_Id", "dbo.Otels");
            DropForeignKey("dbo.Yorums", "Otel_Id", "dbo.Otels");
            DropForeignKey("dbo.Yildizs", "Yorum_Id", "dbo.Yorums");
            DropForeignKey("dbo.Yorums", "Musteri_Id", "dbo.Musteris");
            DropForeignKey("dbo.Yildizs", "Otel_Id", "dbo.Otels");
            DropForeignKey("dbo.Otels", "Adresi_Id", "dbo.İl");
            DropForeignKey("dbo.İlce", "İl_Id", "dbo.İl");
            DropForeignKey("dbo.Mahalles", "İlce_Id", "dbo.İlce");
            DropIndex("dbo.Rezervasyons", new[] { "Oda_Id" });
            DropIndex("dbo.Rezervasyons", new[] { "Musteri_Id" });
            DropIndex("dbo.OtelResimleris", new[] { "Otel_Id" });
            DropIndex("dbo.Yorums", new[] { "Otel_Id" });
            DropIndex("dbo.Yorums", new[] { "Musteri_Id" });
            DropIndex("dbo.Yildizs", new[] { "Yorum_Id" });
            DropIndex("dbo.Yildizs", new[] { "Otel_Id" });
            DropIndex("dbo.Otels", new[] { "Adresi_Id" });
            DropIndex("dbo.Odas", new[] { "Otel_Id" });
            DropIndex("dbo.Mahalles", new[] { "İlce_Id" });
            DropIndex("dbo.İlce", new[] { "İl_Id" });
            DropTable("dbo.Rezervasyons");
            DropTable("dbo.OtelResimleris");
            DropTable("dbo.Ozelliks");
            DropTable("dbo.Yorums");
            DropTable("dbo.Yildizs");
            DropTable("dbo.Otels");
            DropTable("dbo.Odas");
            DropTable("dbo.Musteris");
            DropTable("dbo.İl");
            DropTable("dbo.Mahalles");
            DropTable("dbo.İlce");
        }
    }
}
