using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsEF.Dac;
using WindowsEF.Models;

namespace WindowsEF
{
    public partial class FrmCategoria : Form
    {
        public FrmCategoria()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            //Creamos un objeto instancia de Categoria
            Categoria categoria = new Categoria() { Nombre = txtNombre.Text };

            int filasAfectadas = AbmCategoria.Insert(categoria);

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Insert OK");
                MostrarTodasCategorias();
            }
        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            MostrarTodasCategorias();
        }

        private void MostrarTodasCategorias()
        {
            GridCategoria.DataSource = AbmCategoria.SelectAll();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //Creamos un objeto instancia de Categoria
            Categoria categoria = new Categoria() { Nombre = txtNombre.Text, Id=Convert.ToInt32(txtId.Text) };

            int filasAfectadas = AbmCategoria.Update(categoria);

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Update OK");
                MostrarTodasCategorias();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Creamos un objeto instancia de Categoria
            Categoria categoria = new Categoria() { Nombre = txtNombre.Text, Id = Convert.ToInt32(txtId.Text) };


            int filasAfectadas = AbmCategoria.Delete(categoria);

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Delete OK");
                MostrarTodasCategorias();
            }
        }

        private void btnBuscarId_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);

            Categoria categoria = AbmCategoria.SelectWhereById(id);

            MessageBox.Show(categoria.Nombre);
        }
    }
}
