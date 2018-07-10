namespace SmartMvc.Data.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MovimentBox : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MovimentBox",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TypeMoviment = c.String(nullable: false, maxLength: 100, unicode: false),
                        DateMoviment = c.DateTime(nullable: false),
                        Box_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Box", t => t.Box_Id)
                .Index(t => t.Box_Id);

        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MovimentBox", "Box_Id", "dbo.Box");
            DropIndex("dbo.MovimentBox", new[] { "Box_Id" });
            DropTable("dbo.MovimentBox");
        }
    }
}
