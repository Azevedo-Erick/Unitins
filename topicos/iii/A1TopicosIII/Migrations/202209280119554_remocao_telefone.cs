namespace A1TopicosIII.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class remocao_telefone : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Empresas", "endereco_id", "dbo.Enderecos");
            DropForeignKey("dbo.ResponsaveisEmpresa", "endereco_id", "dbo.Enderecos");
            DropForeignKey("dbo.ResponsaveisEmpresa", "telefone_id", "dbo.Telefones");
            DropForeignKey("dbo.Empresas", "telefone_id", "dbo.Telefones");
            DropForeignKey("dbo.Usuarios", "endereco_id", "dbo.Enderecos");
            DropIndex("dbo.Empresas", new[] { "endereco_id" });
            DropIndex("dbo.Empresas", new[] { "telefone_id" });
            DropIndex("dbo.ResponsaveisEmpresa", new[] { "endereco_id" });
            DropIndex("dbo.ResponsaveisEmpresa", new[] { "telefone_id" });
            DropIndex("dbo.Usuarios", new[] { "endereco_id" });
            AddColumn("dbo.Empresas", "cep", c => c.String());
            AddColumn("dbo.Empresas", "cidade", c => c.String());
            AddColumn("dbo.Empresas", "estado", c => c.String());
            AddColumn("dbo.Empresas", "bairro", c => c.String());
            AddColumn("dbo.Empresas", "complemento", c => c.String());
            AddColumn("dbo.Empresas", "numero", c => c.String());
            AddColumn("dbo.Empresas", "ddd", c => c.String());
            AddColumn("dbo.Empresas", "numero_telefone", c => c.String());
            AddColumn("dbo.ResponsaveisEmpresa", "cep", c => c.String());
            AddColumn("dbo.ResponsaveisEmpresa", "cidade", c => c.String());
            AddColumn("dbo.ResponsaveisEmpresa", "estado", c => c.String());
            AddColumn("dbo.ResponsaveisEmpresa", "bairro", c => c.String());
            AddColumn("dbo.ResponsaveisEmpresa", "complemento", c => c.String());
            AddColumn("dbo.ResponsaveisEmpresa", "numero", c => c.String());
            AddColumn("dbo.ResponsaveisEmpresa", "ddd", c => c.String());
            AddColumn("dbo.ResponsaveisEmpresa", "numero_telefone", c => c.String());
            DropColumn("dbo.Empresas", "endereco_id");
            DropColumn("dbo.Empresas", "telefone_id");
            DropColumn("dbo.ResponsaveisEmpresa", "endereco_id");
            DropColumn("dbo.ResponsaveisEmpresa", "telefone_id");
            DropColumn("dbo.Usuarios", "endereco_id");
            DropTable("dbo.Enderecos");
            DropTable("dbo.Telefones");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Telefones",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ddd = c.String(),
                        numero = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Enderecos",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        cep = c.String(),
                        cidade = c.String(),
                        estado = c.String(),
                        bairro = c.String(),
                        complemento = c.String(),
                        numero = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            AddColumn("dbo.Usuarios", "endereco_id", c => c.Int());
            AddColumn("dbo.ResponsaveisEmpresa", "telefone_id", c => c.Int());
            AddColumn("dbo.ResponsaveisEmpresa", "endereco_id", c => c.Int());
            AddColumn("dbo.Empresas", "telefone_id", c => c.Int());
            AddColumn("dbo.Empresas", "endereco_id", c => c.Int());
            DropColumn("dbo.ResponsaveisEmpresa", "numero_telefone");
            DropColumn("dbo.ResponsaveisEmpresa", "ddd");
            DropColumn("dbo.ResponsaveisEmpresa", "numero");
            DropColumn("dbo.ResponsaveisEmpresa", "complemento");
            DropColumn("dbo.ResponsaveisEmpresa", "bairro");
            DropColumn("dbo.ResponsaveisEmpresa", "estado");
            DropColumn("dbo.ResponsaveisEmpresa", "cidade");
            DropColumn("dbo.ResponsaveisEmpresa", "cep");
            DropColumn("dbo.Empresas", "numero_telefone");
            DropColumn("dbo.Empresas", "ddd");
            DropColumn("dbo.Empresas", "numero");
            DropColumn("dbo.Empresas", "complemento");
            DropColumn("dbo.Empresas", "bairro");
            DropColumn("dbo.Empresas", "estado");
            DropColumn("dbo.Empresas", "cidade");
            DropColumn("dbo.Empresas", "cep");
            CreateIndex("dbo.Usuarios", "endereco_id");
            CreateIndex("dbo.ResponsaveisEmpresa", "telefone_id");
            CreateIndex("dbo.ResponsaveisEmpresa", "endereco_id");
            CreateIndex("dbo.Empresas", "telefone_id");
            CreateIndex("dbo.Empresas", "endereco_id");
            AddForeignKey("dbo.Usuarios", "endereco_id", "dbo.Enderecos", "id");
            AddForeignKey("dbo.Empresas", "telefone_id", "dbo.Telefones", "id");
            AddForeignKey("dbo.ResponsaveisEmpresa", "telefone_id", "dbo.Telefones", "id");
            AddForeignKey("dbo.ResponsaveisEmpresa", "endereco_id", "dbo.Enderecos", "id");
            AddForeignKey("dbo.Empresas", "endereco_id", "dbo.Enderecos", "id");
        }
    }
}
