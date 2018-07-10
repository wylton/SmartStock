namespace SmartMvc.Data.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MovimentBox_Alteracoes : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.MovimentBox", "Box_Id", "dbo.Box");
            DropIndex("dbo.MovimentBox", new[] { "Invoice_Id" });
            DropIndex("dbo.MovimentBox", new[] { "Box_Id" });
            AlterColumn("dbo.MovimentBox", "Invoice_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.MovimentBox", "Invoice_Id");
            DropColumn("dbo.MovimentBox", "Box_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MovimentBox", "Box_Id", c => c.Int(nullable: false));
            DropIndex("dbo.MovimentBox", new[] { "Invoice_Id" });
            AlterColumn("dbo.MovimentBox", "Invoice_Id", c => c.Int());
            CreateIndex("dbo.MovimentBox", "Box_Id");
            CreateIndex("dbo.MovimentBox", "Invoice_Id");
            AddForeignKey("dbo.MovimentBox", "Box_Id", "dbo.Box", "Id");
        }
    }
}
