namespace ProyectoFinalCsharp.EstructurasdeDatos.Listas.ListaDobleCircular
{
    partial class ListaDobleCircular
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaDobleCircular));
            this.lblThis = new System.Windows.Forms.Label();
            this.lblLista = new System.Windows.Forms.Label();
            this.lblDato = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtNodo = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBorrarL = new System.Windows.Forms.Button();
            this.btnContar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblThis
            // 
            this.lblThis.AutoSize = true;
            this.lblThis.BackColor = System.Drawing.Color.Snow;
            this.lblThis.Font = new System.Drawing.Font("Britannic Bold", 16.2F);
            this.lblThis.ForeColor = System.Drawing.Color.YellowGreen;
            this.lblThis.Location = new System.Drawing.Point(253, 153);
            this.lblThis.Name = "lblThis";
            this.lblThis.Size = new System.Drawing.Size(81, 31);
            this.lblThis.TabIndex = 0;
            this.lblThis.Text = "Lista:";
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.BackColor = System.Drawing.Color.Snow;
            this.lblLista.Font = new System.Drawing.Font("Britannic Bold", 16.2F);
            this.lblLista.ForeColor = System.Drawing.Color.YellowGreen;
            this.lblLista.Location = new System.Drawing.Point(358, 153);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(42, 31);
            this.lblLista.TabIndex = 1;
            this.lblLista.Text = "----";
            // 
            // lblDato
            // 
            this.lblDato.AutoSize = true;
            this.lblDato.BackColor = System.Drawing.Color.Snow;
            this.lblDato.Font = new System.Drawing.Font("Britannic Bold", 16.2F);
            this.lblDato.ForeColor = System.Drawing.Color.YellowGreen;
            this.lblDato.Location = new System.Drawing.Point(253, 271);
            this.lblDato.Name = "lblDato";
            this.lblDato.Size = new System.Drawing.Size(79, 31);
            this.lblDato.TabIndex = 2;
            this.lblDato.Text = "Dato:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Snow;
            this.lblTitulo.Font = new System.Drawing.Font("Elephant", 22.2F);
            this.lblTitulo.ForeColor = System.Drawing.Color.YellowGreen;
            this.lblTitulo.Location = new System.Drawing.Point(226, 39);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(414, 49);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Lista Doble Circular";
            // 
            // txtNodo
            // 
            this.txtNodo.BackColor = System.Drawing.Color.Snow;
            this.txtNodo.Font = new System.Drawing.Font("Britannic Bold", 10.2F);
            this.txtNodo.ForeColor = System.Drawing.Color.YellowGreen;
            this.txtNodo.Location = new System.Drawing.Point(364, 277);
            this.txtNodo.Name = "txtNodo";
            this.txtNodo.Size = new System.Drawing.Size(134, 26);
            this.txtNodo.TabIndex = 4;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Snow;
            this.btnAgregar.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.Color.YellowGreen;
            this.btnAgregar.Location = new System.Drawing.Point(96, 118);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(129, 58);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Snow;
            this.btnEliminar.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.YellowGreen;
            this.btnEliminar.Location = new System.Drawing.Point(96, 209);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(129, 58);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBorrarL
            // 
            this.btnBorrarL.BackColor = System.Drawing.Color.Snow;
            this.btnBorrarL.Enabled = false;
            this.btnBorrarL.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.btnBorrarL.ForeColor = System.Drawing.Color.YellowGreen;
            this.btnBorrarL.Location = new System.Drawing.Point(96, 300);
            this.btnBorrarL.Name = "btnBorrarL";
            this.btnBorrarL.Size = new System.Drawing.Size(129, 58);
            this.btnBorrarL.TabIndex = 7;
            this.btnBorrarL.Text = "Borrar Lista";
            this.btnBorrarL.UseVisualStyleBackColor = false;
            this.btnBorrarL.Click += new System.EventHandler(this.btnBorrarL_Click);
            // 
            // btnContar
            // 
            this.btnContar.BackColor = System.Drawing.Color.Snow;
            this.btnContar.Enabled = false;
            this.btnContar.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.btnContar.ForeColor = System.Drawing.Color.YellowGreen;
            this.btnContar.Location = new System.Drawing.Point(640, 118);
            this.btnContar.Name = "btnContar";
            this.btnContar.Size = new System.Drawing.Size(129, 58);
            this.btnContar.TabIndex = 8;
            this.btnContar.Text = "Contar";
            this.btnContar.UseVisualStyleBackColor = false;
            this.btnContar.Click += new System.EventHandler(this.btnContar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Snow;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.YellowGreen;
            this.btnGuardar.Location = new System.Drawing.Point(640, 209);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(129, 58);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar Lista";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.Snow;
            this.btnCargar.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.btnCargar.ForeColor = System.Drawing.Color.YellowGreen;
            this.btnCargar.Location = new System.Drawing.Point(640, 300);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(129, 58);
            this.btnCargar.TabIndex = 10;
            this.btnCargar.Text = "Cargar Lista";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Snow;
            this.btnMenu.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnMenu.ForeColor = System.Drawing.Color.YellowGreen;
            this.btnMenu.Location = new System.Drawing.Point(766, 405);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(90, 43);
            this.btnMenu.TabIndex = 11;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // ListaDobleCircular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(951, 481);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnContar);
            this.Controls.Add(this.btnBorrarL);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNodo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblDato);
            this.Controls.Add(this.lblLista);
            this.Controls.Add(this.lblThis);
            this.Name = "ListaDobleCircular";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista Doble Circular";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ListaDobleCircular_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThis;
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.Label lblDato;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtNodo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBorrarL;
        private System.Windows.Forms.Button btnContar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnMenu;
    }
}