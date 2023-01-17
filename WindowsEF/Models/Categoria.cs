using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace WindowsEF.Models
{
    [Table("Categoria")]//Cambiar el nopmbre de la tabla
    public class Categoria
    {
        public int Id { get; set; } //usa la convension de EF para indicar que en SQL SERVER la columna Id sea CLAVE PRINCIPAL AUTONUMERICA

        [Column(TypeName = "varchar")]//tipo de datos SQL Server
        [StringLength(50)]//long de la cadena
        [Required]//Obligatorio, no acepta null
        public string Nombre { get; set; }

        public List<Producto> Productos { get; set; }

    }
}
