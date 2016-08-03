namespace EstagiarioWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _0 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Computers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Marcaplacamae = c.String(),
                        modeloplacamae = c.String(),
                        capacidaderam = c.String(),
                        quantidaderam = c.Int(nullable: false),
                        capacidadehd = c.String(),
                        quantidadehd = c.String(),
                        modelofone = c.String(),
                        marcafone = c.String(),
                        marcaprocessador = c.String(),
                        velocidadeprocessador = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ComputersNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.ComputersNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.ComputersNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.ComputersNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.ComputersNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.ComputersNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ComputersNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.ComputersNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.ComputersNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ComputersNetUserRoles", "UserId", "dbo.ComputersNetUsers");
            DropForeignKey("dbo.ComputersNetUserLogins", "UserId", "dbo.ComputersNetUsers");
            DropForeignKey("dbo.ComputersNetUserClaims", "UserId", "dbo.ComputersNetUsers");
            DropForeignKey("dbo.ComputersNetUserRoles", "RoleId", "dbo.ComputersNetRoles");
            DropIndex("dbo.ComputersNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.ComputersNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.ComputersNetUsers", "UserNameIndex");
            DropIndex("dbo.ComputersNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.ComputersNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.ComputersNetRoles", "RoleNameIndex");
            DropTable("dbo.ComputersNetUserLogins");
            DropTable("dbo.ComputersNetUserClaims");
            DropTable("dbo.ComputersNetUsers");
            DropTable("dbo.ComputersNetUserRoles");
            DropTable("dbo.ComputersNetRoles");
            DropTable("dbo.Computers");
        }
    }
}
