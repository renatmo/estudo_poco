namespace br.com.LojaVeiculos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nome_mae : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TB_CLIENTE", "NM_MAE", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TB_CLIENTE", "NM_MAE");
        }
    }
}
