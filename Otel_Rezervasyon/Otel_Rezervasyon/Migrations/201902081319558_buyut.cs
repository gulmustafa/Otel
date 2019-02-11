namespace Otel_Rezervasyon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class buyut : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.İlce", "İlceAdi", c => c.String(maxLength: 100));
            AlterColumn("dbo.Mahalles", "MahalleAdi", c => c.String(maxLength: 100));
            AlterColumn("dbo.İller", "İlAdi", c => c.String(maxLength: 100));
            AlterColumn("dbo.Musteris", "Adi", c => c.String(maxLength: 100));
            AlterColumn("dbo.Musteris", "Soyadi", c => c.String(maxLength: 100));
            AlterColumn("dbo.Musteris", "Sifre", c => c.String(maxLength: 100));
            AlterColumn("dbo.Musteris", "KullaniciAdi", c => c.String(maxLength: 100));
            AlterColumn("dbo.Musteris", "TelefonNo", c => c.String(maxLength: 15));
            AlterColumn("dbo.Musteris", "Email", c => c.String(maxLength: 100));
            AlterColumn("dbo.Musteris", "TCNO", c => c.String(maxLength: 11));
            AlterColumn("dbo.Odas", "OdaNo", c => c.String(maxLength: 20));
            AlterColumn("dbo.Otels", "Adi", c => c.String(maxLength: 100));
            AlterColumn("dbo.Otels", "ResmiAdi", c => c.String(maxLength: 100));
            AlterColumn("dbo.Yorums", "YorumBasligi", c => c.String(maxLength: 100));
            AlterColumn("dbo.Yorums", "YorumIcerigi", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Yorums", "YorumIcerigi", c => c.String());
            AlterColumn("dbo.Yorums", "YorumBasligi", c => c.String());
            AlterColumn("dbo.Otels", "ResmiAdi", c => c.String());
            AlterColumn("dbo.Otels", "Adi", c => c.String());
            AlterColumn("dbo.Odas", "OdaNo", c => c.String());
            AlterColumn("dbo.Musteris", "TCNO", c => c.String());
            AlterColumn("dbo.Musteris", "Email", c => c.String());
            AlterColumn("dbo.Musteris", "TelefonNo", c => c.String());
            AlterColumn("dbo.Musteris", "KullaniciAdi", c => c.String());
            AlterColumn("dbo.Musteris", "Sifre", c => c.String());
            AlterColumn("dbo.Musteris", "Soyadi", c => c.String());
            AlterColumn("dbo.Musteris", "Adi", c => c.String());
            AlterColumn("dbo.İller", "İlAdi", c => c.String());
            AlterColumn("dbo.Mahalles", "MahalleAdi", c => c.String());
            AlterColumn("dbo.İlce", "İlceAdi", c => c.String());
        }
    }
}
