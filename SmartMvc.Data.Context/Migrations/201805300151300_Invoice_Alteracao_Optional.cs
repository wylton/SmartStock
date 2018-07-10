namespace SmartMvc.Data.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Invoice_Alteracao_Optional : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.MovimentBox", new[] { "Invoice_Id" });
            AlterColumn("dbo.MovimentBox", "Invoice_Id", c => c.Int());
            CreateIndex("dbo.MovimentBox", "Invoice_Id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.MovimentBox", new[] { "Invoice_Id" });
            AlterColumn("dbo.MovimentBox", "Invoice_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.MovimentBox", "Invoice_Id");
        }
    }
}
