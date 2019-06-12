namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deleteImageFile : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Foods", "ImageFile");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Foods", "ImageFile", c => c.String());
        }
    }
}
