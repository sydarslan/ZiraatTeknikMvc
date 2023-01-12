namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Brands",
                c => new
                    {
                        BrandId = c.Int(nullable: false, identity: true),
                        BrandName = c.String(),
                        BrandStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.BrandId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        ProductCode = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ProductDescription = c.String(),
                        CategoryId = c.Int(nullable: false),
                        SubCategoryId = c.Int(nullable: false),
                        BrandId = c.Int(nullable: false),
                        ProductStatus = c.Boolean(nullable: false),
                        ProductDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.Brands", t => t.BrandId, cascadeDelete: true)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.SubCategories", t => t.SubCategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId)
                .Index(t => t.SubCategoryId)
                .Index(t => t.BrandId);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(maxLength: 20),
                        CategoryStatus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.SubCategories",
                c => new
                    {
                        SubCategoryId = c.Int(nullable: false, identity: true),
                        SubCategoryName = c.String(),
                        SubCategoryStatus = c.Boolean(nullable: false),
                        CategoryId = c.Int(),
                    })
                .PrimaryKey(t => t.SubCategoryId)
                .ForeignKey("dbo.Categories", t => t.CategoryId)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Stocks",
                c => new
                    {
                        StockId = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StockId)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        ContactId = c.Int(nullable: false, identity: true),
                        UserName = c.String(maxLength: 50),
                        UserMail = c.String(maxLength: 50),
                        Subject = c.String(maxLength: 50),
                        ContactDate = c.DateTime(nullable: false),
                        Message = c.String(),
                    })
                .PrimaryKey(t => t.ContactId);
            
            CreateTable(
                "dbo.Coupons",
                c => new
                    {
                        CouponId = c.Int(nullable: false, identity: true),
                        CouponCode = c.String(),
                        CouponPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CouponStatus = c.Boolean(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CouponId)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        UserStatus = c.Boolean(nullable: false),
                        UserDate = c.DateTime(nullable: false),
                        Address = c.String(),
                        UserProvinceId = c.Int(nullable: false),
                        UserDistrictId = c.Int(nullable: false),
                        UserRoleId = c.Int(nullable: false),
                        UserProvince_ProvinceId = c.Int(),
                        UserDistrict_DistrictId = c.Int(),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.UserProvinces", t => t.UserProvince_ProvinceId)
                .ForeignKey("dbo.UserDistricts", t => t.UserDistrict_DistrictId)
                .ForeignKey("dbo.UserRoles", t => t.UserRoleId, cascadeDelete: true)
                .Index(t => t.UserRoleId)
                .Index(t => t.UserProvince_ProvinceId)
                .Index(t => t.UserDistrict_DistrictId);
            
            CreateTable(
                "dbo.UserDistricts",
                c => new
                    {
                        DistrictId = c.Int(nullable: false, identity: true),
                        DistrictName = c.String(),
                        UserProvinceId = c.Int(nullable: false),
                        UserProvince_ProvinceId = c.Int(),
                    })
                .PrimaryKey(t => t.DistrictId)
                .ForeignKey("dbo.UserProvinces", t => t.UserProvince_ProvinceId)
                .Index(t => t.UserProvince_ProvinceId);
            
            CreateTable(
                "dbo.UserProvinces",
                c => new
                    {
                        ProvinceId = c.Int(nullable: false, identity: true),
                        ProvinceName = c.String(),
                    })
                .PrimaryKey(t => t.ProvinceId);
            
            CreateTable(
                "dbo.UserRoles",
                c => new
                    {
                        UserRoleId = c.Int(nullable: false, identity: true),
                        RoleName = c.String(),
                    })
                .PrimaryKey(t => t.UserRoleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "UserRoleId", "dbo.UserRoles");
            DropForeignKey("dbo.Users", "UserDistrict_DistrictId", "dbo.UserDistricts");
            DropForeignKey("dbo.Users", "UserProvince_ProvinceId", "dbo.UserProvinces");
            DropForeignKey("dbo.UserDistricts", "UserProvince_ProvinceId", "dbo.UserProvinces");
            DropForeignKey("dbo.Coupons", "UserId", "dbo.Users");
            DropForeignKey("dbo.Stocks", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Products", "SubCategoryId", "dbo.SubCategories");
            DropForeignKey("dbo.SubCategories", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Products", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Products", "BrandId", "dbo.Brands");
            DropIndex("dbo.UserDistricts", new[] { "UserProvince_ProvinceId" });
            DropIndex("dbo.Users", new[] { "UserDistrict_DistrictId" });
            DropIndex("dbo.Users", new[] { "UserProvince_ProvinceId" });
            DropIndex("dbo.Users", new[] { "UserRoleId" });
            DropIndex("dbo.Coupons", new[] { "UserId" });
            DropIndex("dbo.Stocks", new[] { "ProductId" });
            DropIndex("dbo.SubCategories", new[] { "CategoryId" });
            DropIndex("dbo.Products", new[] { "BrandId" });
            DropIndex("dbo.Products", new[] { "SubCategoryId" });
            DropIndex("dbo.Products", new[] { "CategoryId" });
            DropTable("dbo.UserRoles");
            DropTable("dbo.UserProvinces");
            DropTable("dbo.UserDistricts");
            DropTable("dbo.Users");
            DropTable("dbo.Coupons");
            DropTable("dbo.Contacts");
            DropTable("dbo.Stocks");
            DropTable("dbo.SubCategories");
            DropTable("dbo.Categories");
            DropTable("dbo.Products");
            DropTable("dbo.Brands");
        }
    }
}
