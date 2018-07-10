namespace SmartMvc.Data.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_MovimentItem : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MovimentItem",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Box_Id = c.Int(nullable: false),
                        MovimentBox_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Box", t => t.Box_Id)
                .ForeignKey("dbo.MovimentBox", t => t.MovimentBox_Id)
                .Index(t => t.Box_Id)
                .Index(t => t.MovimentBox_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MovimentItem", "MovimentBox_Id", "dbo.MovimentBox");
            DropForeignKey("dbo.MovimentItem", "Box_Id", "dbo.Box");
            DropIndex("dbo.MovimentItem", new[] { "MovimentBox_Id" });
            DropIndex("dbo.MovimentItem", new[] { "Box_Id" });
            DropTable("dbo.MovimentItem");
        }
    }
}
