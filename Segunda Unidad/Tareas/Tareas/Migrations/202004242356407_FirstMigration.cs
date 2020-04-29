namespace Tareas.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Tasks", "StartDate", c => c.DateTime());
            AlterColumn("dbo.Tasks", "EndDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Tasks", "EndDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Tasks", "StartDate", c => c.DateTime(nullable: false));
        }
    }
}
