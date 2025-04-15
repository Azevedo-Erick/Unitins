namespace A1TopicosIII.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adicao_responsavel_contrato : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contratos", "responsavel_id", c => c.Int());
            CreateIndex("dbo.Contratos", "responsavel_id");
            AddForeignKey("dbo.Contratos", "responsavel_id", "dbo.Usuarios", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Contratos", "responsavel_id", "dbo.Usuarios");
            DropIndex("dbo.Contratos", new[] { "responsavel_id" });
            DropColumn("dbo.Contratos", "responsavel_id");
        }
    }
}
