namespace InterfazGrafica
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDetalle = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // Configuración del Formulario
            this.Text = "CRUD SQL Server - Kevin";
            this.Size = new System.Drawing.Size(800, 450);
            this.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            // DataGridView (Tabla)
            this.dgvDatos.Location = new System.Drawing.Point(300, 30);
            this.dgvDatos.Size = new System.Drawing.Size(450, 350);
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // Etiquetas y Textbox
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(30, 30);

            this.txtNombre.Location = new System.Drawing.Point(30, 50);
            this.txtNombre.Size = new System.Drawing.Size(230, 25);

            this.lblDetalle.Text = "Detalle:";
            this.lblDetalle.ForeColor = System.Drawing.Color.White;
            this.lblDetalle.Location = new System.Drawing.Point(30, 90);

            this.txtDetalle.Location = new System.Drawing.Point(30, 110);
            this.txtDetalle.Size = new System.Drawing.Size(230, 25);

            // Botón Guardar
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.Location = new System.Drawing.Point(30, 160);
            this.btnGuardar.Size = new System.Drawing.Size(230, 40);
            this.btnGuardar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            // Botón Eliminar
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.Location = new System.Drawing.Point(30, 210);
            this.btnEliminar.Size = new System.Drawing.Size(230, 40);
            this.btnEliminar.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            // Agregar Controles
            this.Controls.Add(dgvDatos);
            this.Controls.Add(lblNombre);
            this.Controls.Add(txtNombre);
            this.Controls.Add(lblDetalle);
            this.Controls.Add(txtDetalle);
            this.Controls.Add(btnGuardar);
            this.Controls.Add(btnEliminar);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDetalle;
    }
}