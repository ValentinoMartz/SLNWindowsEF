namespace WindowsEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClaveForanea : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Producto", "Categoria_Id", "dbo.Categoria");
            DropIndex("dbo.Producto", new[] { "Categoria_Id" });
            RenameColumn(table: "dbo.Producto", name: "Categoria_Id", newName: "CategoriaId");
            AlterColumn("dbo.Producto", "CategoriaId", c => c.Int(nullable: false));
            CreateIndex("dbo.Producto", "CategoriaId");
            AddForeignKey("dbo.Producto", "CategoriaId", "dbo.Categoria", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Producto", "CategoriaId", "dbo.Categoria");
            DropIndex("dbo.Producto", new[] { "CategoriaId" });
            AlterColumn("dbo.Producto", "CategoriaId", c => c.Int());
            RenameColumn(table: "dbo.Producto", name: "CategoriaId", newName: "Categoria_Id");
            CreateIndex("dbo.Producto", "Categoria_Id");
            AddForeignKey("dbo.Producto", "Categoria_Id", "dbo.Categoria", "Id");
        }
    }
}
