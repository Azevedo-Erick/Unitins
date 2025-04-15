namespace A1TopicosIII.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class correcao_empresa_resonsavel : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Empresas", name: "reponsavel_id", newName: "responsavel_id");
            RenameIndex(table: "dbo.Empresas", name: "IX_reponsavel_id", newName: "IX_responsavel_id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Empresas", name: "IX_responsavel_id", newName: "IX_reponsavel_id");
            RenameColumn(table: "dbo.Empresas", name: "responsavel_id", newName: "reponsavel_id");
        }
    }
}
