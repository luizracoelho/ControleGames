namespace ControleGames.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Distribuidoras",
                c => new
                    {
                        DistribuidoraId = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.DistribuidoraId);
            
            CreateTable(
                "dbo.Games",
                c => new
                    {
                        GameId = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        AnoLancamento = c.Int(nullable: false),
                        Categoria = c.Int(nullable: false),
                        Plataforma = c.Int(nullable: false),
                        ValorVenda = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Distribuidora_DistribuidoraId = c.Int(),
                    })
                .PrimaryKey(t => t.GameId)
                .ForeignKey("dbo.Distribuidoras", t => t.Distribuidora_DistribuidoraId)
                .Index(t => t.Distribuidora_DistribuidoraId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Games", "Distribuidora_DistribuidoraId", "dbo.Distribuidoras");
            DropIndex("dbo.Games", new[] { "Distribuidora_DistribuidoraId" });
            DropTable("dbo.Games");
            DropTable("dbo.Distribuidoras");
        }
    }
}
