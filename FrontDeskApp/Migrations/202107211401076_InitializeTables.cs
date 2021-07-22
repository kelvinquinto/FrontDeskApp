namespace FrontDeskApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitializeTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblCategory",
                c => new
                    {
                        intCategoryId = c.Int(nullable: false, identity: true),
                        strCategory = c.String(),
                        intLimit = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.intCategoryId);
            
            CreateTable(
                "dbo.tblPackage",
                c => new
                    {
                        intPackageId = c.Int(nullable: false, identity: true),
                        intCustomerId = c.Int(nullable: false),
                        intCategoryId = c.Int(nullable: false),
                        intFacilityId = c.Int(nullable: false),
                        strStatus = c.String(),
                        dtmDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.intPackageId)
                .ForeignKey("dbo.tblCategory", t => t.intCategoryId, cascadeDelete: true)
                .ForeignKey("dbo.tblCustomer", t => t.intCustomerId, cascadeDelete: true)
                .ForeignKey("dbo.tblFacility", t => t.intFacilityId, cascadeDelete: true)
                .Index(t => t.intCustomerId)
                .Index(t => t.intCategoryId)
                .Index(t => t.intFacilityId);
            
            CreateTable(
                "dbo.tblCustomer",
                c => new
                    {
                        intCustomerId = c.Int(nullable: false, identity: true),
                        strFirstName = c.String(),
                        strLastName = c.String(),
                        strPhoneNumber = c.String(),
                    })
                .PrimaryKey(t => t.intCustomerId);
            
            CreateTable(
                "dbo.tblFacility",
                c => new
                    {
                        intFacilityId = c.Int(nullable: false, identity: true),
                        strFacilityName = c.String(),
                        intSmall = c.Int(),
                        intMedium = c.Int(),
                        intLarge = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.intFacilityId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblPackage", "intFacilityId", "dbo.tblFacility");
            DropForeignKey("dbo.tblPackage", "intCustomerId", "dbo.tblCustomer");
            DropForeignKey("dbo.tblPackage", "intCategoryId", "dbo.tblCategory");
            DropIndex("dbo.tblPackage", new[] { "intFacilityId" });
            DropIndex("dbo.tblPackage", new[] { "intCategoryId" });
            DropIndex("dbo.tblPackage", new[] { "intCustomerId" });
            DropTable("dbo.tblFacility");
            DropTable("dbo.tblCustomer");
            DropTable("dbo.tblPackage");
            DropTable("dbo.tblCategory");
        }
    }
}
