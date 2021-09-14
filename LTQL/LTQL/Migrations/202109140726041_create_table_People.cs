namespace LTQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_People : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PeopleID = c.String(nullable: false, maxLength: 128),
                        PeopleName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.PeopleID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.People");
        }
    }
}
