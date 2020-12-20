namespace ProyectoFinalCsharp.EstructurasdeDatos.Arboles
{
    partial class Arbol
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
            this.lblThis = new System.Windows.Forms.Label();
            this.txtNodo = new System.Windows.Forms.TextBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnIdentificar = new System.Windows.Forms.Button();
            this.btnAltura = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gbRecorrer = new System.Windows.Forms.GroupBox();
            this.btnRecorrer = new System.Windows.Forms.Button();
            this.rbtnPostOrden = new System.Windows.Forms.RadioButton();
            this.rbtnPreOrden = new System.Windows.Forms.RadioButton();
            this.rbtnOrden = new System.Windows.Forms.RadioButton();
            this.lblDato = new System.Windows.Forms.Label();
            this.gbRecorrer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblThis
            // 
            this.lblThis.AutoSize = true;
            this.lblThis.BackColor = System.Drawing.Color.Snow;
            this.lblThis.Font = new System.Drawing.Font("Britannic Bold", 16.2F);
            this.lblThis.ForeColor = System.Drawing.Color.Plum;
            this.lblThis.Location = new System.Drawing.Point(771, 457);
            this.lblThis.Name = "lblThis";
            this.lblThis.Size = new System.Drawing.Size(395, 31);
            this.lblThis.TabIndex = 0;
            this.lblThis.Text = "Encontrar el maximo y minimo";
            // 
            // txtNodo
            // 
            this.txtNodo.BackColor = System.Drawing.Color.Snow;
            this.txtNodo.Font = new System.Drawing.Font("Britannic Bold", 10.2F);
            this.txtNodo.ForeColor = System.Drawing.Color.Plum;
            this.txtNodo.Location = new System.Drawing.Point(316, 513);
            this.txtNodo.Name = "txtNodo";
            this.txtNodo.Size = new System.Drawing.Size(134, 26);
            this.txtNodo.TabIndex = 1;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Snow;
            this.btnMenu.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnMenu.ForeColor = System.Drawing.Color.Plum;
            this.btnMenu.Location = new System.Drawing.Point(1112, 734);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(90, 43);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Snow;
            this.btnAgregar.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.Color.Plum;
            this.btnAgregar.Location = new System.Drawing.Point(55, 508);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(144, 43);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Snow;
            this.btnBuscar.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor = System.Drawing.Color.Plum;
            this.btnBuscar.Location = new System.Drawing.Point(55, 636);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(144, 43);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Snow;
            this.btnEliminar.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.Plum;
            this.btnEliminar.Location = new System.Drawing.Point(55, 573);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(144, 43);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnIdentificar
            // 
            this.btnIdentificar.BackColor = System.Drawing.Color.Snow;
            this.btnIdentificar.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnIdentificar.ForeColor = System.Drawing.Color.Plum;
            this.btnIdentificar.Location = new System.Drawing.Point(777, 504);
            this.btnIdentificar.Name = "btnIdentificar";
            this.btnIdentificar.Size = new System.Drawing.Size(199, 43);
            this.btnIdentificar.TabIndex = 6;
            this.btnIdentificar.Text = "Identificar";
            this.btnIdentificar.UseVisualStyleBackColor = false;
            this.btnIdentificar.Click += new System.EventHandler(this.btnIdentificar_Click);
            // 
            // btnAltura
            // 
            this.btnAltura.BackColor = System.Drawing.Color.Snow;
            this.btnAltura.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnAltura.ForeColor = System.Drawing.Color.Plum;
            this.btnAltura.Location = new System.Drawing.Point(777, 572);
            this.btnAltura.Name = "btnAltura";
            this.btnAltura.Size = new System.Drawing.Size(199, 43);
            this.btnAltura.TabIndex = 7;
            this.btnAltura.Text = "Determinar Altura";
            this.btnAltura.UseVisualStyleBackColor = false;
            this.btnAltura.Click += new System.EventHandler(this.btnAltura_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.Snow;
            this.btnCargar.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnCargar.ForeColor = System.Drawing.Color.Plum;
            this.btnCargar.Location = new System.Drawing.Point(777, 640);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(199, 43);
            this.btnCargar.TabIndex = 8;
            this.btnCargar.Text = "Cargar Arbol";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Snow;
            this.btnGuardar.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.Plum;
            this.btnGuardar.Location = new System.Drawing.Point(777, 709);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(199, 43);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar Arbol";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // gbRecorrer
            // 
            this.gbRecorrer.BackColor = System.Drawing.Color.Snow;
            this.gbRecorrer.Controls.Add(this.btnRecorrer);
            this.gbRecorrer.Controls.Add(this.rbtnPostOrden);
            this.gbRecorrer.Controls.Add(this.rbtnPreOrden);
            this.gbRecorrer.Controls.Add(this.rbtnOrden);
            this.gbRecorrer.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.gbRecorrer.ForeColor = System.Drawing.Color.Plum;
            this.gbRecorrer.Location = new System.Drawing.Point(489, 494);
            this.gbRecorrer.Name = "gbRecorrer";
            this.gbRecorrer.Size = new System.Drawing.Size(252, 261);
            this.gbRecorrer.TabIndex = 10;
            this.gbRecorrer.TabStop = false;
            this.gbRecorrer.Text = "Recorrer:";
            // 
            // btnRecorrer
            // 
            this.btnRecorrer.BackColor = System.Drawing.Color.Snow;
            this.btnRecorrer.ForeColor = System.Drawing.Color.Plum;
            this.btnRecorrer.Location = new System.Drawing.Point(60, 175);
            this.btnRecorrer.Name = "btnRecorrer";
            this.btnRecorrer.Size = new System.Drawing.Size(144, 43);
            this.btnRecorrer.TabIndex = 3;
            this.btnRecorrer.Text = "Recorrer";
            this.btnRecorrer.UseVisualStyleBackColor = false;
            this.btnRecorrer.Click += new System.EventHandler(this.btnRecorrer_Click);
            // 
            // rbtnPostOrden
            // 
            this.rbtnPostOrden.AutoSize = true;
            this.rbtnPostOrden.Location = new System.Drawing.Point(19, 135);
            this.rbtnPostOrden.Name = "rbtnPostOrden";
            this.rbtnPostOrden.Size = new System.Drawing.Size(130, 26);
            this.rbtnPostOrden.TabIndex = 2;
            this.rbtnPostOrden.TabStop = true;
            this.rbtnPostOrden.Text = "Post Orden";
            this.rbtnPostOrden.UseVisualStyleBackColor = true;
            // 
            // rbtnPreOrden
            // 
            this.rbtnPreOrden.AutoSize = true;
            this.rbtnPreOrden.Location = new System.Drawing.Point(19, 89);
            this.rbtnPreOrden.Name = "rbtnPreOrden";
            this.rbtnPreOrden.Size = new System.Drawing.Size(122, 26);
            this.rbtnPreOrden.TabIndex = 1;
            this.rbtnPreOrden.TabStop = true;
            this.rbtnPreOrden.Text = "Pre Orden";
            this.rbtnPreOrden.UseVisualStyleBackColor = true;
            // 
            // rbtnOrden
            // 
            this.rbtnOrden.AutoSize = true;
            this.rbtnOrden.Location = new System.Drawing.Point(19, 44);
            this.rbtnOrden.Name = "rbtnOrden";
            this.rbtnOrden.Size = new System.Drawing.Size(85, 26);
            this.rbtnOrden.TabIndex = 0;
            this.rbtnOrden.TabStop = true;
            this.rbtnOrden.Text = "Orden";
            this.rbtnOrden.UseVisualStyleBackColor = true;
            // 
            // lblDato
            // 
            this.lblDato.AutoSize = true;
            this.lblDato.BackColor = System.Drawing.Color.Snow;
            this.lblDato.Font = new System.Drawing.Font("Britannic Bold", 16.2F);
            this.lblDato.ForeColor = System.Drawing.Color.Plum;
            this.lblDato.Location = new System.Drawing.Point(218, 508);
            this.lblDato.Name = "lblDato";
            this.lblDato.Size = new System.Drawing.Size(79, 31);
            this.lblDato.TabIndex = 11;
            this.lblDato.Text = "Dato:";
            // 
            // Arbol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1239, 800);
            this.Controls.Add(this.lblDato);
            this.Controls.Add(this.gbRecorrer);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnAltura);
            this.Controls.Add(this.btnIdentificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.txtNodo);
            this.Controls.Add(this.lblThis);
            this.Name = "Arbol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arbol";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Arbol_FormClosed);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Arbol_Paint);
            this.gbRecorrer.ResumeLayout(false);
            this.gbRecorrer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThis;
        private System.Windows.Forms.TextBox txtNodo;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnIdentificar;
        private System.Windows.Forms.Button btnAltura;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox gbRecorrer;
        private System.Windows.Forms.Button btnRecorrer;
        private System.Windows.Forms.RadioButton rbtnPostOrden;
        private System.Windows.Forms.RadioButton rbtnPreOrden;
        private System.Windows.Forms.RadioButton rbtnOrden;
        private System.Windows.Forms.Label lblDato;
    }
}