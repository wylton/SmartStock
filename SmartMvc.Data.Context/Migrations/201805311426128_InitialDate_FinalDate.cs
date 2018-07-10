namespace SmartMvc.Data.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDate_FinalDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MovimentBox", "InitialDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.MovimentBox", "FinalDate", c => c.DateTime());
            DropColumn("dbo.MovimentBox", "DateMoviment");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MovimentBox", "DateMoviment", c => c.DateTime(nullable: false));
            DropColumn("dbo.MovimentBox", "FinalDate");
            DropColumn("dbo.MovimentBox", "InitialDate");
        }
    }
}
