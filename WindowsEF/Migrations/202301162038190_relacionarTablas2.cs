namespace WindowsEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class relacionarTablas2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProductoCategorias", "Producto_ProductoId", "dbo.Producto");
            DropForeignKey("dbo.ProductoCategorias", "Categoria_Id", "dbo.Categoria");
            DropIndex("dbo.ProductoCategorias", new[] { "Producto_ProductoId" });
            DropIndex("dbo.ProductoCategorias", new[] { "Categoria_Id" });
            AddColumn("dbo.Producto", "Categoria_Id", c => c.Int());
            CreateIndex("dbo.Producto", "Categoria_Id");
            AddForeignKey("dbo.Producto", "Categoria_Id", "dbo.Categoria", "Id");
            DropTable("dbo.ProductoCategorias");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ProductoCategorias",
                c => new
                    {
                        Producto_ProductoId = c.Int(nullable: false),
                        Categoria_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Producto_ProductoId, t.Categoria_Id });
            
            DropForeignKey("dbo.Producto", "Categoria_Id", "dbo.Categoria");
            DropIndex("dbo.Producto", new[] { "Categoria_Id" });
            DropColumn("dbo.Producto", "Categoria_Id");
            CreateIndex("dbo.ProductoCategorias", "Categoria_Id");
            CreateIndex("dbo.ProductoCategorias", "Producto_ProductoId");
            AddForeignKey("dbo.ProductoCategorias", "Categoria_Id", "dbo.Categoria", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ProductoCategorias", "Producto_ProductoId", "dbo.Producto", "Id", cascadeDelete: true);
        }
    }
}
