namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migr1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Jobs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Topik = c.String(nullable: false),
                        Name = c.String(nullable: false),
                        Salary = c.Int(nullable: false),
                        ImgPath = c.String(),
                        NumberOfEmployees = c.String(nullable: false),
                        Info = c.String(nullable: false),
                        YourPosition = c.String(nullable: false),
                        City_Id = c.Int(nullable: false),
                        Type_Id = c.Int(nullable: false),
                        User_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.City_Id, cascadeDelete: true)
                .ForeignKey("dbo.Types", t => t.Type_Id, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.User_Id, cascadeDelete: true)
                .Index(t => t.City_Id)
                .Index(t => t.Type_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Types",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        SName = c.String(nullable: false),
                        TName = c.String(nullable: false),
                        NickName = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        PhoneNumber = c.String(nullable: false),
                        CityId = c.Int(nullable: false),
                        Age = c.Int(nullable: false),
                        Resume = c.String(),
                        Email = c.String(nullable: false),
                        ImgPath = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Jobs", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Jobs", "Type_Id", "dbo.Types");
            DropForeignKey("dbo.Jobs", "City_Id", "dbo.Cities");
            DropIndex("dbo.Jobs", new[] { "User_Id" });
            DropIndex("dbo.Jobs", new[] { "Type_Id" });
            DropIndex("dbo.Jobs", new[] { "City_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.Types");
            DropTable("dbo.Jobs");
            DropTable("dbo.Cities");
        }
    }
}
