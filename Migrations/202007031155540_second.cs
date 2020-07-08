namespace HR_match.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Vacancies", "Category", c => c.String(nullable: false));
            AlterColumn("dbo.Vacancies", "Mobile", c => c.String(nullable: false, maxLength: 13));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Vacancies", "Mobile", c => c.String(maxLength: 13));
            DropColumn("dbo.Vacancies", "Category");
        }
    }
}
