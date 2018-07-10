namespace SmartMvc.Data.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TypeNumberInvoice : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Invoice", "NumberInvoice", c => c.String(nullable: false, maxLength: 15, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Invoice", "NumberInvoice", c => c.String(nullable: false, maxLength: 15, fixedLength: true, unicode: false));
        }
    }
}
