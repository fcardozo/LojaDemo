namespace LojaDemo.Infrastructure.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategoryAndProducts : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LojaDemo_Category",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LojaDemo_Product",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        IdCategory = c.Guid(nullable: false),
                        Name = c.String(nullable: false, maxLength: 100),
                        FullPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DiscountPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IsPromotion = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.LojaDemo_Category", t => t.IdCategory, cascadeDelete: true)
                .Index(t => t.IdCategory);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LojaDemo_Product", "IdCategory", "dbo.LojaDemo_Category");
            DropIndex("dbo.LojaDemo_Product", new[] { "IdCategory" });
            DropTable("dbo.LojaDemo_Product");
            DropTable("dbo.LojaDemo_Category");
        }
    }
}
