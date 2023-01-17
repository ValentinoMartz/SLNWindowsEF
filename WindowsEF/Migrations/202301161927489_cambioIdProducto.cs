namespace WindowsEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cambioIdProducto : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Producto", name: "ProductoId", newName: "Id");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.Producto", name: "Id", newName: "ProductoId");
        }
    }
}
