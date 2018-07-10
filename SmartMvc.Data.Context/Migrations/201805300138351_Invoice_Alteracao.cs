namespace SmartMvc.Data.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Invoice_Alteracao : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MovimentBox", "Invoice_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.MovimentBox", "Invoice_Id");
            AddForeignKey("dbo.MovimentBox", "Invoice_Id", "dbo.Invoice", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MovimentBox", "Invoice_Id", "dbo.Invoice");
            DropIndex("dbo.MovimentBox", new[] { "Invoice_Id" });
            DropColumn("dbo.MovimentBox", "Invoice_Id");
        }
    }
}
