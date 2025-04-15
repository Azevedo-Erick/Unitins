namespace A1TopicosIII.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Remocao_cidade_estado : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Cidades", "estado_id", "dbo.Estados");
            DropForeignKey("dbo.Emails", "Empresa_id", "dbo.Empresas");
            DropForeignKey("dbo.Enderecos", "cidade_id", "dbo.Logs");
            DropForeignKey("dbo.Faxes", "Empresa_id", "dbo.Empresas");
            DropForeignKey("dbo.Telefones", "Empresa_id", "dbo.Empresas");
            DropIndex("dbo.Cidades", new[] { "estado_id" });
            DropIndex("dbo.Emails", new[] { "Empresa_id" });
            DropIndex("dbo.Enderecos", new[] { "cidade_id" });
            DropIndex("dbo.Faxes", new[] { "Empresa_id" });
            DropIndex("dbo.Telefones", new[] { "Empresa_id" });
            AddColumn("dbo.Empresas", "email_id", c => c.Int());
            AddColumn("dbo.Empresas", "fax_id", c => c.Int());
            AddColumn("dbo.Empresas", "telefone_id", c => c.Int());
            AddColumn("dbo.Enderecos", "cidade", c => c.String());
            AddColumn("dbo.Enderecos", "estado", c => c.String());
            CreateIndex("dbo.Empresas", "email_id");
            CreateIndex("dbo.Empresas", "fax_id");
            CreateIndex("dbo.Empresas", "telefone_id");
            AddForeignKey("dbo.Empresas", "email_id", "dbo.Emails", "id");
            AddForeignKey("dbo.Empresas", "fax_id", "dbo.Faxes", "id");
            AddForeignKey("dbo.Empresas", "telefone_id", "dbo.Telefones", "id");
            DropColumn("dbo.Emails", "Empresa_id");
            DropColumn("dbo.Enderecos", "cidade_id");
            DropColumn("dbo.Faxes", "Empresa_id");
            DropColumn("dbo.Telefones", "Empresa_id");
            DropTable("dbo.Cidades");
            DropTable("dbo.Estados");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Estados",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Cidades",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome = c.String(),
                        estado_id = c.Int(),
                    })
                .PrimaryKey(t => t.id);
            
            AddColumn("dbo.Telefones", "Empresa_id", c => c.Int());
            AddColumn("dbo.Faxes", "Empresa_id", c => c.Int());
            AddColumn("dbo.Enderecos", "cidade_id", c => c.Int());
            AddColumn("dbo.Emails", "Empresa_id", c => c.Int());
            DropForeignKey("dbo.Empresas", "telefone_id", "dbo.Telefones");
            DropForeignKey("dbo.Empresas", "fax_id", "dbo.Faxes");
            DropForeignKey("dbo.Empresas", "email_id", "dbo.Emails");
            DropIndex("dbo.Empresas", new[] { "telefone_id" });
            DropIndex("dbo.Empresas", new[] { "fax_id" });
            DropIndex("dbo.Empresas", new[] { "email_id" });
            DropColumn("dbo.Enderecos", "estado");
            DropColumn("dbo.Enderecos", "cidade");
            DropColumn("dbo.Empresas", "telefone_id");
            DropColumn("dbo.Empresas", "fax_id");
            DropColumn("dbo.Empresas", "email_id");
            CreateIndex("dbo.Telefones", "Empresa_id");
            CreateIndex("dbo.Faxes", "Empresa_id");
            CreateIndex("dbo.Enderecos", "cidade_id");
            CreateIndex("dbo.Emails", "Empresa_id");
            CreateIndex("dbo.Cidades", "estado_id");
            AddForeignKey("dbo.Telefones", "Empresa_id", "dbo.Empresas", "id");
            AddForeignKey("dbo.Faxes", "Empresa_id", "dbo.Empresas", "id");
            AddForeignKey("dbo.Enderecos", "cidade_id", "dbo.Logs", "id");
            AddForeignKey("dbo.Emails", "Empresa_id", "dbo.Empresas", "id");
            AddForeignKey("dbo.Cidades", "estado_id", "dbo.Estados", "id");
        }
    }
}
