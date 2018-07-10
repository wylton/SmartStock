namespace SmartMvc.Data.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Box : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.EntryBox", "BoxId", "dbo.Box");
            DropForeignKey("dbo.OutletBox", "EntryBoxId", "dbo.EntryBox");
            DropForeignKey("dbo.OutletBox", "Box_Id", "dbo.Box");
            DropIndex("dbo.EntryBox", new[] { "BoxId" });
            DropIndex("dbo.OutletBox", new[] { "EntryBoxId" });
            DropIndex("dbo.OutletBox", new[] { "Box_Id" });
            DropTable("dbo.EntryBox");
            DropTable("dbo.OutletBox");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.OutletBox",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateMoviment = c.DateTime(nullable: false),
                        EntryBoxId = c.Int(nullable: false),
                        Box_Id = c.Int(),
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
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.OutletBox", "Box_Id");
            CreateIndex("dbo.OutletBox", "EntryBoxId");
            CreateIndex("dbo.EntryBox", "BoxId");
            AddForeignKey("dbo.OutletBox", "Box_Id", "dbo.Box", "Id");
            AddForeignKey("dbo.OutletBox", "EntryBoxId", "dbo.EntryBox", "Id");
            AddForeignKey("dbo.EntryBox", "BoxId", "dbo.Box", "Id");
        }
    }
}
