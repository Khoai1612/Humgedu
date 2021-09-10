namespace LTQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_SinhVien : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SinhViens",
                c => new
                    {
                        MaSV = c.String(nullable: false, maxLength: 128),
                        TenSV = c.String(),
                    })
                .PrimaryKey(t => t.MaSV);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SinhViens");
        }
    }
}
