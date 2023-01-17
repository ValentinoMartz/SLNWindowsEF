using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEF.Models
{
    [Table("Producto")]
    public class Producto
    {
        [Key]
        [Column("Id")]
        public int ProductoId { get; set; }

        [Column(TypeName = "varchar")]//tipo de datos SQL Server
        [StringLength(50)]//long de la cadena
        [Required]//Obligatorio, no acepta null
        public string Nombre { get; set; }


        [Column(TypeName = "money")]
        public decimal Precio{ get; set; }

        [Column(TypeName = "char")]
        [StringLength(1)]
        public string LineaProducto{ get; set; }

        public int CategoriaId { get; set; }
        [ForeignKey("CategoriaId")]
        public Categoria Categoria { get; set; }
    }
}
