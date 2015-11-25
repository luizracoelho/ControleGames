namespace ControleGames.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Remover_Distribuidora : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Games", "Distribuidora_DistribuidoraId", "dbo.Distribuidoras");
            DropIndex("dbo.Games", new[] { "Distribuidora_DistribuidoraId" });
            AddColumn("dbo.Games", "Distribuidora", c => c.String());
            DropColumn("dbo.Games", "Distribuidora_DistribuidoraId");
            DropTable("dbo.Distribuidoras");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Distribuidoras",
                c => new
                    {
                        DistribuidoraId = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.DistribuidoraId);
            
            AddColumn("dbo.Games", "Distribuidora_DistribuidoraId", c => c.Int());
            DropColumn("dbo.Games", "Distribuidora");
            CreateIndex("dbo.Games", "Distribuidora_DistribuidoraId");
            AddForeignKey("dbo.Games", "Distribuidora_DistribuidoraId", "dbo.Distribuidoras", "DistribuidoraId");
        }
    }
}
