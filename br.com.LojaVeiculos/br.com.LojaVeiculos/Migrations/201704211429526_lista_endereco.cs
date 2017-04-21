namespace br.com.LojaVeiculos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class lista_endereco : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TB_ENDERECO", "TB_CLIENTE_ID_cliente", "dbo.TB_CLIENTE");
            DropIndex("dbo.TB_ENDERECO", new[] { "TB_CLIENTE_ID_cliente" });
            DropTable("dbo.TB_ENDERECO");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.TB_ENDERECO",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        NM_LOGRADOURO = c.String(),
                        DS_COMPLEMENTO = c.String(),
                        DS_NUMERO = c.String(),
                        SG_UF = c.String(),
                        NM_BAIRRO = c.String(),
                        TB_CLIENTE_ID_cliente = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateIndex("dbo.TB_ENDERECO", "TB_CLIENTE_ID_cliente");
            AddForeignKey("dbo.TB_ENDERECO", "TB_CLIENTE_ID_cliente", "dbo.TB_CLIENTE", "ID_cliente");
        }
    }
}
