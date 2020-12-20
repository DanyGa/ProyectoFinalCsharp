namespace ProyectoFinalCsharp.EstructurasdeDatos.Colas
{
    partial class Colas
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
            this.lblCola = new System.Windows.Forms.Label();
            this.lblDato = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtNodo = new System.Windows.Forms.TextBox();
            this.btnEncolar = new System.Windows.Forms.Button();
            this.btnDesencolar = new System.Windows.Forms.Button();
            this.btnBorrarC = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
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
            this.lblThis.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblThis.Location = new System.Drawing.Point(253, 153);
            this.lblThis.Name = "lblThis";
            this.lblThis.Size = new System.Drawing.Size(77, 31);
            this.lblThis.TabIndex = 0;
            this.lblThis.Text = "Cola:";
            // 
            // lblCola
            // 
            this.lblCola.AutoSize = true;
            this.lblCola.BackColor = System.Drawing.Color.Snow;
            this.lblCola.Font = new System.Drawing.Font("Britannic Bold", 16.2F);
            this.lblCola.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblCola.Location = new System.Drawing.Point(358, 153);
            this.lblCola.Name = "lblCola";
            this.lblCola.Size = new System.Drawing.Size(42, 31);
            this.lblCola.TabIndex = 1;
            this.lblCola.Text = "----";
            // 
            // lblDato
            // 
            this.lblDato.AutoSize = true;
            this.lblDato.BackColor = System.Drawing.Color.Snow;
            this.lblDato.Font = new System.Drawing.Font("Britannic Bold", 16.2F);
            this.lblDato.ForeColor = System.Drawing.Color.SteelBlue;
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
            this.lblTitulo.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTitulo.Location = new System.Drawing.Point(379, 39);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(127, 49);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Colas";
            // 
            // txtNodo
            // 
            this.txtNodo.BackColor = System.Drawing.Color.Snow;
            this.txtNodo.Font = new System.Drawing.Font("Britannic Bold", 10.2F);
            this.txtNodo.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtNodo.Location = new System.Drawing.Point(364, 277);
            this.txtNodo.Name = "txtNodo";
            this.txtNodo.Size = new System.Drawing.Size(134, 26);
            this.txtNodo.TabIndex = 4;
            // 
            // btnEncolar
            // 
            this.btnEncolar.BackColor = System.Drawing.Color.Snow;
            this.btnEncolar.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.btnEncolar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnEncolar.Location = new System.Drawing.Point(96, 118);
            this.btnEncolar.Name = "btnEncolar";
            this.btnEncolar.Size = new System.Drawing.Size(129, 58);
            this.btnEncolar.TabIndex = 5;
            this.btnEncolar.Text = "Encolar";
            this.btnEncolar.UseVisualStyleBackColor = false;
            this.btnEncolar.Click += new System.EventHandler(this.btnEncolar_Click);
            // 
            // btnDesencolar
            // 
            this.btnDesencolar.BackColor = System.Drawing.Color.Snow;
            this.btnDesencolar.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.btnDesencolar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnDesencolar.Location = new System.Drawing.Point(96, 209);
            this.btnDesencolar.Name = "btnDesencolar";
            this.btnDesencolar.Size = new System.Drawing.Size(129, 58);
            this.btnDesencolar.TabIndex = 6;
            this.btnDesencolar.Text = "Desencolar";
            this.btnDesencolar.UseVisualStyleBackColor = false;
            this.btnDesencolar.Click += new System.EventHandler(this.btnDesencolar_Click);
            // 
            // btnBorrarC
            // 
            this.btnBorrarC.BackColor = System.Drawing.Color.Snow;
            this.btnBorrarC.Enabled = false;
            this.btnBorrarC.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.btnBorrarC.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnBorrarC.Location = new System.Drawing.Point(96, 300);
            this.btnBorrarC.Name = "btnBorrarC";
            this.btnBorrarC.Size = new System.Drawing.Size(129, 58);
            this.btnBorrarC.TabIndex = 7;
            this.btnBorrarC.Text = "Borrar Cola";
            this.btnBorrarC.UseVisualStyleBackColor = false;
            this.btnBorrarC.Click += new System.EventHandler(this.btnBorrarC_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.Snow;
            this.btnConsultar.Enabled = false;
            this.btnConsultar.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.btnConsultar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnConsultar.Location = new System.Drawing.Point(640, 118);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(129, 58);
            this.btnConsultar.TabIndex = 8;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Snow;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnGuardar.Location = new System.Drawing.Point(640, 209);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(129, 58);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar Cola";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.Snow;
            this.btnCargar.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.btnCargar.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnCargar.Location = new System.Drawing.Point(640, 300);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(129, 58);
            this.btnCargar.TabIndex = 10;
            this.btnCargar.Text = "Cargar Cola";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Snow;
            this.btnMenu.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnMenu.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnMenu.Location = new System.Drawing.Point(766, 405);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(90, 43);
            this.btnMenu.TabIndex = 11;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // Colas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoFinalCsharp.Properties.Resources.Colas;
            this.ClientSize = new System.Drawing.Size(951, 481);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnBorrarC);
            this.Controls.Add(this.btnDesencolar);
            this.Controls.Add(this.btnEncolar);
            this.Controls.Add(this.txtNodo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblDato);
            this.Controls.Add(this.lblCola);
            this.Controls.Add(this.lblThis);
            this.Name = "Colas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Colas_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThis;
        private System.Windows.Forms.Label lblCola;
        private System.Windows.Forms.Label lblDato;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtNodo;
        private System.Windows.Forms.Button btnEncolar;
        private System.Windows.Forms.Button btnDesencolar;
        private System.Windows.Forms.Button btnBorrarC;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnMenu;
    }
}