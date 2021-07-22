namespace FrontDeskApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitializeTables1 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.tblFacility", "intSmall");
            DropColumn("dbo.tblFacility", "intMedium");
            DropColumn("dbo.tblFacility", "intLarge");
            DropColumn("dbo.tblFacility", "Discriminator");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tblFacility", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.tblFacility", "intLarge", c => c.Int());
            AddColumn("dbo.tblFacility", "intMedium", c => c.Int());
            AddColumn("dbo.tblFacility", "intSmall", c => c.Int());
        }
    }
}
