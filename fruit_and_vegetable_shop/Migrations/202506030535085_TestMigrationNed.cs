﻿namespace fruit_and_vegetable_shop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TestMigrationNed : DbMigration
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
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.VeganTypes", t => t.VeganTypeId, cascadeDelete: true)
                .Index(t => t.VeganTypeId);
            
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
            DropIndex("dbo.Vegans", new[] { "VeganTypeId" });
            DropTable("dbo.VeganTypes");
            DropTable("dbo.Vegans");
        }
    }
}
