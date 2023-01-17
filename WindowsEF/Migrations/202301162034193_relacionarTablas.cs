namespace WindowsEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class relacionarTablas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ProductoCategorias",
                c => new
                    {
                        Producto_ProductoId = c.Int(nullable: false),
                        Categoria_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Producto_ProductoId, t.Categoria_Id })
                .ForeignKey("dbo.Producto", t => t.Producto_ProductoId, cascadeDelete: true)
                .ForeignKey("dbo.Categoria", t => t.Categoria_Id, cascadeDelete: true)
                .Index(t => t.Producto_ProductoId)
                .Index(t => t.Categoria_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductoCategorias", "Categoria_Id", "dbo.Categoria");
            DropForeignKey("dbo.ProductoCategorias", "Producto_ProductoId", "dbo.Producto");
            DropIndex("dbo.ProductoCategorias", new[] { "Categoria_Id" });
            DropIndex("dbo.ProductoCategorias", new[] { "Producto_ProductoId" });
            DropTable("dbo.ProductoCategorias");
        }
    }
}
