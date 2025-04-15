namespace A1TopicosIII.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class remocao_fax_email : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Empresas", "email_id", "dbo.Emails");
            DropForeignKey("dbo.Empresas", "fax_id", "dbo.Faxes");
            DropForeignKey("dbo.Emails", "ContatoResponsavelEmpresa_id", "dbo.ResponsaveisEmpresa");
            DropForeignKey("dbo.Faxes", "ContatoResponsavelEmpresa_id", "dbo.ResponsaveisEmpresa");
            DropForeignKey("dbo.Telefones", "ContatoResponsavelEmpresa_id", "dbo.ResponsaveisEmpresa");
            DropIndex("dbo.Empresas", new[] { "email_id" });
            DropIndex("dbo.Empresas", new[] { "fax_id" });
            DropIndex("dbo.Emails", new[] { "ContatoResponsavelEmpresa_id" });
            DropIndex("dbo.Faxes", new[] { "ContatoResponsavelEmpresa_id" });
            DropIndex("dbo.Telefones", new[] { "ContatoResponsavelEmpresa_id" });
            AddColumn("dbo.Empresas", "fax", c => c.String());
            AddColumn("dbo.Empresas", "email", c => c.String());
            AddColumn("dbo.ResponsaveisEmpresa", "fax", c => c.String());
            AddColumn("dbo.ResponsaveisEmpresa", "email", c => c.String());
            AddColumn("dbo.ResponsaveisEmpresa", "telefone_id", c => c.Int());
            CreateIndex("dbo.ResponsaveisEmpresa", "telefone_id");
            AddForeignKey("dbo.ResponsaveisEmpresa", "telefone_id", "dbo.Telefones", "id");
            DropColumn("dbo.Empresas", "email_id");
            DropColumn("dbo.Empresas", "fax_id");
            DropColumn("dbo.Telefones", "ContatoResponsavelEmpresa_id");
            DropTable("dbo.Emails");
            DropTable("dbo.Faxes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Faxes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        fax = c.String(),
                        ContatoResponsavelEmpresa_id = c.Int(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Emails",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        email = c.String(),
                        ContatoResponsavelEmpresa_id = c.Int(),
                    })
                .PrimaryKey(t => t.id);
            
            AddColumn("dbo.Telefones", "ContatoResponsavelEmpresa_id", c => c.Int());
            AddColumn("dbo.Empresas", "fax_id", c => c.Int());
            AddColumn("dbo.Empresas", "email_id", c => c.Int());
            DropForeignKey("dbo.ResponsaveisEmpresa", "telefone_id", "dbo.Telefones");
            DropIndex("dbo.ResponsaveisEmpresa", new[] { "telefone_id" });
            DropColumn("dbo.ResponsaveisEmpresa", "telefone_id");
            DropColumn("dbo.ResponsaveisEmpresa", "email");
            DropColumn("dbo.ResponsaveisEmpresa", "fax");
            DropColumn("dbo.Empresas", "email");
            DropColumn("dbo.Empresas", "fax");
            CreateIndex("dbo.Telefones", "ContatoResponsavelEmpresa_id");
            CreateIndex("dbo.Faxes", "ContatoResponsavelEmpresa_id");
            CreateIndex("dbo.Emails", "ContatoResponsavelEmpresa_id");
            CreateIndex("dbo.Empresas", "fax_id");
            CreateIndex("dbo.Empresas", "email_id");
            AddForeignKey("dbo.Telefones", "ContatoResponsavelEmpresa_id", "dbo.ResponsaveisEmpresa", "id");
            AddForeignKey("dbo.Faxes", "ContatoResponsavelEmpresa_id", "dbo.ResponsaveisEmpresa", "id");
            AddForeignKey("dbo.Emails", "ContatoResponsavelEmpresa_id", "dbo.ResponsaveisEmpresa", "id");
            AddForeignKey("dbo.Empresas", "fax_id", "dbo.Faxes", "id");
            AddForeignKey("dbo.Empresas", "email_id", "dbo.Emails", "id");
        }
    }
}
