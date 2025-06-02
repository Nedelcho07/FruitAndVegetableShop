namespace fruit_and_vegetable_shop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TestMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Vegans",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        VeganTypeId = c.Int(nullable: false),
                        Vegans_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Vegans", t => t.Vegans_Id)
                .ForeignKey("dbo.VeganTypes", t => t.VeganTypeId, cascadeDelete: true)
                .Index(t => t.VeganTypeId)
                .Index(t => t.Vegans_Id);
            
            CreateTable(
                "dbo.VeganTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vegans", "VeganTypeId", "dbo.VeganTypes");
            DropForeignKey("dbo.Vegans", "Vegans_Id", "dbo.Vegans");
            DropIndex("dbo.Vegans", new[] { "Vegans_Id" });
            DropIndex("dbo.Vegans", new[] { "VeganTypeId" });
            DropTable("dbo.VeganTypes");
            DropTable("dbo.Vegans");
        }
    }
}
