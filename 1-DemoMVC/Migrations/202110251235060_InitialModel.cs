namespace _1_DemoMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Produits",
                c => new
                    {
                        iD = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Prix = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.iD);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Produits");
        }
    }
}
