namespace ProyectoFinalCsharp.EstructurasdeDatos.Pilas
{
    partial class Pilas
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
            this.lblPila = new System.Windows.Forms.Label();
            this.lblThis = new System.Windows.Forms.Label();
            this.lblDato = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNodo = new System.Windows.Forms.TextBox();
            this.btnBorrarP = new System.Windows.Forms.Button();
            this.btnContar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnPush = new System.Windows.Forms.Button();
            this.btnPop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPila
            // 
            this.lblPila.AutoSize = true;
            this.lblPila.BackColor = System.Drawing.Color.Snow;
            this.lblPila.Font = new System.Drawing.Font("Britannic Bold", 16.2F);
            this.lblPila.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblPila.Location = new System.Drawing.Point(358, 153);
            this.lblPila.Name = "lblPila";
            this.lblPila.Size = new System.Drawing.Size(42, 31);
            this.lblPila.TabIndex = 0;
            this.lblPila.Text = "----";
            // 
            // lblThis
            // 
            this.lblThis.AutoSize = true;
            this.lblThis.BackColor = System.Drawing.Color.Snow;
            this.lblThis.Font = new System.Drawing.Font("Britannic Bold", 16.2F);
            this.lblThis.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblThis.Location = new System.Drawing.Point(253, 153);
            this.lblThis.Name = "lblThis";
            this.lblThis.Size = new System.Drawing.Size(70, 31);
            this.lblThis.TabIndex = 1;
            this.lblThis.Text = "Pila:";
            // 
            // lblDato
            // 
            this.lblDato.AutoSize = true;
            this.lblDato.BackColor = System.Drawing.Color.Snow;
            this.lblDato.Font = new System.Drawing.Font("Britannic Bold", 16.2F);
            this.lblDato.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblDato.Location = new System.Drawing.Point(253, 271);
            this.lblDato.Name = "lblDato";
            this.lblDato.Size = new System.Drawing.Size(79, 31);
            this.lblDato.TabIndex = 2;
            this.lblDato.Text = "Dato:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Snow;
            this.label4.Font = new System.Drawing.Font("Elephant", 22.2F);
            this.label4.ForeColor = System.Drawing.Color.CadetBlue;
            this.label4.Location = new System.Drawing.Point(379, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 49);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pilas";
            // 
            // txtNodo
            // 
            this.txtNodo.BackColor = System.Drawing.Color.Snow;
            this.txtNodo.Font = new System.Drawing.Font("Britannic Bold", 10.2F);
            this.txtNodo.ForeColor = System.Drawing.Color.CadetBlue;
            this.txtNodo.Location = new System.Drawing.Point(364, 277);
            this.txtNodo.Name = "txtNodo";
            this.txtNodo.Size = new System.Drawing.Size(134, 26);
            this.txtNodo.TabIndex = 4;
            // 
            // btnBorrarP
            // 
            this.btnBorrarP.BackColor = System.Drawing.Color.Snow;
            this.btnBorrarP.Enabled = false;
            this.btnBorrarP.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.btnBorrarP.ForeColor = System.Drawing.Color.CadetBlue;
            this.btnBorrarP.Location = new System.Drawing.Point(96, 300);
            this.btnBorrarP.Name = "btnBorrarP";
            this.btnBorrarP.Size = new System.Drawing.Size(129, 58);
            this.btnBorrarP.TabIndex = 7;
            this.btnBorrarP.Text = "Borrar Pila";
            this.btnBorrarP.UseVisualStyleBackColor = false;
            this.btnBorrarP.Click += new System.EventHandler(this.btnBorrarP_Click);
            // 
            // btnContar
            // 
            this.btnContar.BackColor = System.Drawing.Color.Snow;
            this.btnContar.Enabled = false;
            this.btnContar.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.btnContar.ForeColor = System.Drawing.Color.CadetBlue;
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
            this.btnGuardar.ForeColor = System.Drawing.Color.CadetBlue;
            this.btnGuardar.Location = new System.Drawing.Point(640, 209);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(129, 58);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar Pila";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.Snow;
            this.btnCargar.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.btnCargar.ForeColor = System.Drawing.Color.CadetBlue;
            this.btnCargar.Location = new System.Drawing.Point(640, 300);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(129, 58);
            this.btnCargar.TabIndex = 10;
            this.btnCargar.Text = "Cargar Pila";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Snow;
            this.btnMenu.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnMenu.ForeColor = System.Drawing.Color.CadetBlue;
            this.btnMenu.Location = new System.Drawing.Point(766, 405);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(90, 43);
            this.btnMenu.TabIndex = 11;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnPush
            // 
            this.btnPush.BackColor = System.Drawing.Color.Snow;
            this.btnPush.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.btnPush.ForeColor = System.Drawing.Color.CadetBlue;
            this.btnPush.Location = new System.Drawing.Point(96, 118);
            this.btnPush.Name = "btnPush";
            this.btnPush.Size = new System.Drawing.Size(129, 58);
            this.btnPush.TabIndex = 12;
            this.btnPush.Text = "Push";
            this.btnPush.UseVisualStyleBackColor = false;
            this.btnPush.Click += new System.EventHandler(this.btnPush_Click);
            // 
            // btnPop
            // 
            this.btnPop.BackColor = System.Drawing.Color.Snow;
            this.btnPop.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.btnPop.ForeColor = System.Drawing.Color.CadetBlue;
            this.btnPop.Location = new System.Drawing.Point(96, 209);
            this.btnPop.Name = "btnPop";
            this.btnPop.Size = new System.Drawing.Size(129, 58);
            this.btnPop.TabIndex = 13;
            this.btnPop.Text = "Pop";
            this.btnPop.UseVisualStyleBackColor = false;
            this.btnPop.Click += new System.EventHandler(this.btnPop_Click);
            // 
            // Pilas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 481);
            this.Controls.Add(this.btnPop);
            this.Controls.Add(this.btnPush);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnContar);
            this.Controls.Add(this.btnBorrarP);
            this.Controls.Add(this.txtNodo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDato);
            this.Controls.Add(this.lblThis);
            this.Controls.Add(this.lblPila);
            this.Name = "Pilas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pilas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Pilas_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPila;
        private System.Windows.Forms.Label lblThis;
        private System.Windows.Forms.Label lblDato;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNodo;
        private System.Windows.Forms.Button btnBorrarP;
        private System.Windows.Forms.Button btnContar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnPush;
        private System.Windows.Forms.Button btnPop;
    }
}