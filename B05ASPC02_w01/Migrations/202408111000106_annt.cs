namespace B05ASPC02_w01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class annt : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "Name", c => c.String(maxLength: 15));
            AlterColumn("dbo.Students", "Description", c => c.String(maxLength: 150));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "Description", c => c.String());
            AlterColumn("dbo.Students", "Name", c => c.String());
        }
    }
}
