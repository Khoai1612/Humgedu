namespace LTQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Coulumn_SinhVien_SDT1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SinhViens", "SDT", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.SinhViens", "SDT");
        }
    }
}
