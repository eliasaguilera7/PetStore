namespace PetStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PetFoods", "Name", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PetFoods", "Name", c => c.Int(nullable: false));
        }
    }
}
