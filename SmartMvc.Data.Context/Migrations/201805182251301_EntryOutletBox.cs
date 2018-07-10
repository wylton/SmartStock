namespace SmartMvc.Data.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EntryOutletBox : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Box",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 100, unicode: false),
                        DatePrinter = c.DateTime(nullable: false),
                        DateChecked = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EntryBox",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateMoviment = c.DateTime(nullable: false),
                        BoxId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Box", t => t.BoxId)
                .Index(t => t.BoxId);

            CreateTable(
                "dbo.OutletBox",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    DateMoviment = c.DateTime(nullable: false),
                    EntryBoxId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.EntryBox", t => t.EntryBoxId)
                .Index(t => t.EntryBoxId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OutletBox", "Box_Id", "dbo.Box");
            DropForeignKey("dbo.OutletBox", "EntryBoxId", "dbo.EntryBox");
            DropForeignKey("dbo.EntryBox", "BoxId", "dbo.Box");
            DropIndex("dbo.OutletBox", new[] { "Box_Id" });
            DropIndex("dbo.OutletBox", new[] { "EntryBoxId" });
            DropIndex("dbo.EntryBox", new[] { "BoxId" });
            DropTable("dbo.OutletBox");
            DropTable("dbo.EntryBox");
            DropTable("dbo.Box");
        }
    }
}
