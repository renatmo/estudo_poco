namespace br.com.LojaVeiculos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nome_pai : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TB_CLIENTE",
                c => new
                    {
                        ID_cliente = c.Int(nullable: false, identity: true),
                        NM_CLIENTE = c.String(nullable: false, maxLength: 300, unicode: false),
                        DT_NASCIMENTO = c.DateTime(nullable: false),
                        FL_ATIVO = c.Boolean(nullable: false),
                        NM_TELEFONE = c.String(nullable: false, maxLength: 50, unicode: false),
                        NM_PAI = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID_cliente);
            
            CreateTable(
                "dbo.TB_VEICULO",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ID_CLIENTE = c.Int(nullable: false),
                        NOM_MARCA = c.String(nullable: false, maxLength: 100, unicode: false),
                        DES_MODELO = c.String(nullable: false, maxLength: 100, unicode: false),
                        NUM_ANO = c.Int(nullable: false),
                        NOM_COR = c.String(nullable: false, maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.TB_CLIENTE", t => t.ID_CLIENTE)
                .Index(t => t.ID_CLIENTE);
            
            CreateTable(
                "dbo.TB_MULTA",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ID_VEICULO = c.Int(nullable: false),
                        DAT_OCORRENCIA = c.DateTime(nullable: false),
                        DES_OCORRENCIA = c.String(nullable: false, maxLength: 300, unicode: false),
                        VAL_MULTA = c.Decimal(nullable: false, precision: 10, scale: 2),
                        QTD_PONTOS = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.TB_VEICULO", t => t.ID_VEICULO)
                .Index(t => t.ID_VEICULO);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TB_VEICULO", "ID_CLIENTE", "dbo.TB_CLIENTE");
            DropForeignKey("dbo.TB_MULTA", "ID_VEICULO", "dbo.TB_VEICULO");
            DropIndex("dbo.TB_MULTA", new[] { "ID_VEICULO" });
            DropIndex("dbo.TB_VEICULO", new[] { "ID_CLIENTE" });
            DropTable("dbo.TB_MULTA");
            DropTable("dbo.TB_VEICULO");
            DropTable("dbo.TB_CLIENTE");
        }
    }
}
