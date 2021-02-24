namespace ProjetoAlarme.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IniciandoProjeto : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alarmes",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Descricao = c.String(),
                        ClassificacaoAlarme = c.Int(nullable: false),
                        DataCadastro = c.DateTime(nullable: false),
                        EquipamentoRelacionado_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Equipamentoes", t => t.EquipamentoRelacionado_Id)
                .Index(t => t.EquipamentoRelacionado_Id);
            
            CreateTable(
                "dbo.AlarmeAtuadoes",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        DataEntrada = c.DateTime(nullable: false),
                        DataSaida = c.DateTime(nullable: false),
                        StatusAlarme = c.Int(nullable: false),
                        Alarme_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Alarmes", t => t.Alarme_Id)
                .Index(t => t.Alarme_Id);
            
            CreateTable(
                "dbo.Equipamentoes",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Nome = c.String(),
                        NumeroSerie = c.String(),
                        TipoEquipamento = c.Int(nullable: false),
                        DataCadastro = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Alarmes", "EquipamentoRelacionado_Id", "dbo.Equipamentoes");
            DropForeignKey("dbo.AlarmeAtuadoes", "Alarme_Id", "dbo.Alarmes");
            DropIndex("dbo.AlarmeAtuadoes", new[] { "Alarme_Id" });
            DropIndex("dbo.Alarmes", new[] { "EquipamentoRelacionado_Id" });
            DropTable("dbo.Equipamentoes");
            DropTable("dbo.AlarmeAtuadoes");
            DropTable("dbo.Alarmes");
        }
    }
}
