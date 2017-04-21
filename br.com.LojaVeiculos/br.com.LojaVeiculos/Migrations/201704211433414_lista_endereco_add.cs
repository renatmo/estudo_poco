namespace br.com.LojaVeiculos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class lista_endereco_add : DbMigration
    {
        public override void Up()
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
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.TB_CLIENTE", t => t.TB_CLIENTE_ID_cliente)
                .Index(t => t.TB_CLIENTE_ID_cliente);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TB_ENDERECO", "TB_CLIENTE_ID_cliente", "dbo.TB_CLIENTE");
            DropIndex("dbo.TB_ENDERECO", new[] { "TB_CLIENTE_ID_cliente" });
            DropTable("dbo.TB_ENDERECO");
        }
    }
}
