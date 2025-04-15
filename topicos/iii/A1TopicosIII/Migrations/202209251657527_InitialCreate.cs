namespace A1TopicosIII.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cidades",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome = c.String(),
                        estado_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Estados", t => t.estado_id)
                .Index(t => t.estado_id);
            
            CreateTable(
                "dbo.Estados",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Contratos",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        quantificadorVigencia = c.Int(nullable: false),
                        tipoVigencia = c.String(),
                        contatante_id = c.Int(),
                        contratado_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Empresas", t => t.contatante_id)
                .ForeignKey("dbo.Empresas", t => t.contratado_id)
                .Index(t => t.contatante_id)
                .Index(t => t.contratado_id);
            
            CreateTable(
                "dbo.Empresas",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        razaoSocial = c.String(),
                        nomeFantasia = c.String(),
                        inscricaoMunicipal = c.String(),
                        inscricaoEstadual = c.String(),
                        porteEmpresa = c.String(),
                        ramoAtividade = c.String(),
                        optantePeloSimples = c.Boolean(nullable: false),
                        endereco_id = c.Int(),
                        reponsavel_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Enderecos", t => t.endereco_id)
                .ForeignKey("dbo.ResponsaveisEmpresa", t => t.reponsavel_id)
                .Index(t => t.endereco_id)
                .Index(t => t.reponsavel_id);
            
            CreateTable(
                "dbo.Emails",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        email = c.String(),
                        Empresa_id = c.Int(),
                        ContatoResponsavelEmpresa_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Empresas", t => t.Empresa_id)
                .ForeignKey("dbo.ResponsaveisEmpresa", t => t.ContatoResponsavelEmpresa_id)
                .Index(t => t.Empresa_id)
                .Index(t => t.ContatoResponsavelEmpresa_id);
            
            CreateTable(
                "dbo.Enderecos",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        cep = c.String(),
                        bairro = c.String(),
                        complemento = c.String(),
                        numero = c.String(),
                        cidade_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Logs", t => t.cidade_id)
                .Index(t => t.cidade_id);
            
            CreateTable(
                "dbo.Logs",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        logDateTime = c.DateTime(nullable: false),
                        texto = c.String(),
                        usuario = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Faxes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        fax = c.String(),
                        Empresa_id = c.Int(),
                        ContatoResponsavelEmpresa_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Empresas", t => t.Empresa_id)
                .ForeignKey("dbo.ResponsaveisEmpresa", t => t.ContatoResponsavelEmpresa_id)
                .Index(t => t.Empresa_id)
                .Index(t => t.ContatoResponsavelEmpresa_id);
            
            CreateTable(
                "dbo.ResponsaveisEmpresa",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nome = c.String(),
                        funcao = c.String(),
                        dataNascimento = c.DateTime(nullable: false),
                        endereco_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Enderecos", t => t.endereco_id)
                .Index(t => t.endereco_id);
            
            CreateTable(
                "dbo.Telefones",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ddd = c.String(),
                        numero = c.String(),
                        ContatoResponsavelEmpresa_id = c.Int(),
                        Empresa_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.ResponsaveisEmpresa", t => t.ContatoResponsavelEmpresa_id)
                .ForeignKey("dbo.Empresas", t => t.Empresa_id)
                .Index(t => t.ContatoResponsavelEmpresa_id)
                .Index(t => t.Empresa_id);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nomeCompleto = c.String(),
                        email = c.String(),
                        senha = c.String(),
                        cargo = c.Int(nullable: false),
                        dataNascimento = c.DateTime(nullable: false),
                        endereco_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Enderecos", t => t.endereco_id)
                .Index(t => t.endereco_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Usuarios", "endereco_id", "dbo.Enderecos");
            DropForeignKey("dbo.Contratos", "contratado_id", "dbo.Empresas");
            DropForeignKey("dbo.Contratos", "contatante_id", "dbo.Empresas");
            DropForeignKey("dbo.Telefones", "Empresa_id", "dbo.Empresas");
            DropForeignKey("dbo.Empresas", "reponsavel_id", "dbo.ResponsaveisEmpresa");
            DropForeignKey("dbo.Telefones", "ContatoResponsavelEmpresa_id", "dbo.ResponsaveisEmpresa");
            DropForeignKey("dbo.Faxes", "ContatoResponsavelEmpresa_id", "dbo.ResponsaveisEmpresa");
            DropForeignKey("dbo.ResponsaveisEmpresa", "endereco_id", "dbo.Enderecos");
            DropForeignKey("dbo.Emails", "ContatoResponsavelEmpresa_id", "dbo.ResponsaveisEmpresa");
            DropForeignKey("dbo.Faxes", "Empresa_id", "dbo.Empresas");
            DropForeignKey("dbo.Empresas", "endereco_id", "dbo.Enderecos");
            DropForeignKey("dbo.Enderecos", "cidade_id", "dbo.Logs");
            DropForeignKey("dbo.Emails", "Empresa_id", "dbo.Empresas");
            DropForeignKey("dbo.Cidades", "estado_id", "dbo.Estados");
            DropIndex("dbo.Usuarios", new[] { "endereco_id" });
            DropIndex("dbo.Telefones", new[] { "Empresa_id" });
            DropIndex("dbo.Telefones", new[] { "ContatoResponsavelEmpresa_id" });
            DropIndex("dbo.ResponsaveisEmpresa", new[] { "endereco_id" });
            DropIndex("dbo.Faxes", new[] { "ContatoResponsavelEmpresa_id" });
            DropIndex("dbo.Faxes", new[] { "Empresa_id" });
            DropIndex("dbo.Enderecos", new[] { "cidade_id" });
            DropIndex("dbo.Emails", new[] { "ContatoResponsavelEmpresa_id" });
            DropIndex("dbo.Emails", new[] { "Empresa_id" });
            DropIndex("dbo.Empresas", new[] { "reponsavel_id" });
            DropIndex("dbo.Empresas", new[] { "endereco_id" });
            DropIndex("dbo.Contratos", new[] { "contratado_id" });
            DropIndex("dbo.Contratos", new[] { "contatante_id" });
            DropIndex("dbo.Cidades", new[] { "estado_id" });
            DropTable("dbo.Usuarios");
            DropTable("dbo.Telefones");
            DropTable("dbo.ResponsaveisEmpresa");
            DropTable("dbo.Faxes");
            DropTable("dbo.Logs");
            DropTable("dbo.Enderecos");
            DropTable("dbo.Emails");
            DropTable("dbo.Empresas");
            DropTable("dbo.Contratos");
            DropTable("dbo.Estados");
            DropTable("dbo.Cidades");
        }
    }
}
