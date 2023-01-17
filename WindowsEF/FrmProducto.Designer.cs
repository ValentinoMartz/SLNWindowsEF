namespace WindowsEF
{
    partial class FrmProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridProductos = new System.Windows.Forms.DataGridView();
            this.btnProdInsertar = new System.Windows.Forms.Button();
            this.btnProdModificar = new System.Windows.Forms.Button();
            this.btnProdEliminar = new System.Windows.Forms.Button();
            this.btnProdBuscaId = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // gridProductos
            // 
            this.gridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProductos.Location = new System.Drawing.Point(63, 168);
            this.gridProductos.Name = "gridProductos";
            this.gridProductos.Size = new System.Drawing.Size(240, 150);
            this.gridProductos.TabIndex = 0;
            // 
            // btnProdInsertar
            // 
            this.btnProdInsertar.Location = new System.Drawing.Point(446, 44);
            this.btnProdInsertar.Name = "btnProdInsertar";
            this.btnProdInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnProdInsertar.TabIndex = 1;
            this.btnProdInsertar.Text = "Insertar";
            this.btnProdInsertar.UseVisualStyleBackColor = true;
            // 
            // btnProdModificar
            // 
            this.btnProdModificar.Location = new System.Drawing.Point(446, 121);
            this.btnProdModificar.Name = "btnProdModificar";
            this.btnProdModificar.Size = new System.Drawing.Size(75, 23);
            this.btnProdModificar.TabIndex = 2;
            this.btnProdModificar.Text = "Modificar";
            this.btnProdModificar.UseVisualStyleBackColor = true;
            // 
            // btnProdEliminar
            // 
            this.btnProdEliminar.Location = new System.Drawing.Point(446, 195);
            this.btnProdEliminar.Name = "btnProdEliminar";
            this.btnProdEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnProdEliminar.TabIndex = 3;
            this.btnProdEliminar.Text = "Eliminar";
            this.btnProdEliminar.UseVisualStyleBackColor = true;
            // 
            // btnProdBuscaId
            // 
            this.btnProdBuscaId.Location = new System.Drawing.Point(446, 269);
            this.btnProdBuscaId.Name = "btnProdBuscaId";
            this.btnProdBuscaId.Size = new System.Drawing.Size(127, 23);
            this.btnProdBuscaId.TabIndex = 4;
            this.btnProdBuscaId.Text = "Buscar por id";
            this.btnProdBuscaId.UseVisualStyleBackColor = true;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(60, 49);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 5;
            this.lblId.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(166, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(166, 96);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 20);
            this.textBox2.TabIndex = 8;
            // 
            // FrmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnProdBuscaId);
            this.Controls.Add(this.btnProdEliminar);
            this.Controls.Add(this.btnProdModificar);
            this.Controls.Add(this.btnProdInsertar);
            this.Controls.Add(this.gridProductos);
            this.Name = "FrmProducto";
            this.Text = "FrmProducto";
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridProductos;
        private System.Windows.Forms.Button btnProdInsertar;
        private System.Windows.Forms.Button btnProdModificar;
        private System.Windows.Forms.Button btnProdEliminar;
        private System.Windows.Forms.Button btnProdBuscaId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}