namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class url : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Foods", "ImageURL", c => c.String());
            AddColumn("dbo.Foods", "ImageFile", c => c.String());
            DropColumn("dbo.Foods", "ImgUrl");
            DropColumn("dbo.Foods", "ImgFile");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Foods", "ImgFile", c => c.String());
            AddColumn("dbo.Foods", "ImgUrl", c => c.String());
            DropColumn("dbo.Foods", "ImageFile");
            DropColumn("dbo.Foods", "ImageURL");
        }
    }
}
