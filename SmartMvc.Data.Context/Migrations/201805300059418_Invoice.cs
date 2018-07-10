namespace SmartMvc.Data.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Invoice : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Invoice",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KeyNf = c.String(nullable: false, maxLength: 44, unicode: false),
                        Filial = c.String(nullable: false, maxLength: 100, unicode: false),
                        NumberInvoice = c.String(nullable: false, maxLength: 15, fixedLength: true, unicode: false),
                        NumberSerieInvoice = c.String(nullable: false, maxLength: 6, unicode: false),
                        Emission = c.DateTime(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Volume = c.Int(nullable: false),
                        Type = c.String(nullable: false, maxLength: 25, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Invoice");
        }
    }
}
