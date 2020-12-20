namespace ProyectoFinalCsharp.EstructurasdeDatos.Listas
{
    partial class MenuListas
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
            this.lblListas = new System.Windows.Forms.Label();
            this.lblInstruccion = new System.Windows.Forms.Label();
            this.btnSimple = new System.Windows.Forms.Button();
            this.btnSCircular = new System.Windows.Forms.Button();
            this.btnDoble = new System.Windows.Forms.Button();
            this.btnDCircular = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblListas
            // 
            this.lblListas.AutoSize = true;
            this.lblListas.BackColor = System.Drawing.Color.Snow;
            this.lblListas.Font = new System.Drawing.Font("Elephant", 25.8F, System.Drawing.FontStyle.Bold);
            this.lblListas.ForeColor = System.Drawing.Color.Firebrick;
            this.lblListas.Location = new System.Drawing.Point(246, 44);
            this.lblListas.Name = "lblListas";
            this.lblListas.Size = new System.Drawing.Size(164, 55);
            this.lblListas.TabIndex = 0;
            this.lblListas.Text = "Listas";
            // 
            // lblInstruccion
            // 
            this.lblInstruccion.AutoSize = true;
            this.lblInstruccion.BackColor = System.Drawing.Color.Snow;
            this.lblInstruccion.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblInstruccion.ForeColor = System.Drawing.Color.Firebrick;
            this.lblInstruccion.Location = new System.Drawing.Point(153, 99);
            this.lblInstruccion.Name = "lblInstruccion";
            this.lblInstruccion.Size = new System.Drawing.Size(346, 30);
            this.lblInstruccion.TabIndex = 1;
            this.lblInstruccion.Text = "Selecciona un tipo de Lista";
            // 
            // btnSimple
            // 
            this.btnSimple.BackColor = System.Drawing.Color.Snow;
            this.btnSimple.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.btnSimple.ForeColor = System.Drawing.Color.Firebrick;
            this.btnSimple.Location = new System.Drawing.Point(133, 181);
            this.btnSimple.Name = "btnSimple";
            this.btnSimple.Size = new System.Drawing.Size(154, 66);
            this.btnSimple.TabIndex = 2;
            this.btnSimple.Text = "Lista Simple";
            this.btnSimple.UseVisualStyleBackColor = false;
            this.btnSimple.Click += new System.EventHandler(this.btnSimple_Click);
            // 
            // btnSCircular
            // 
            this.btnSCircular.BackColor = System.Drawing.Color.Snow;
            this.btnSCircular.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.btnSCircular.ForeColor = System.Drawing.Color.Firebrick;
            this.btnSCircular.Location = new System.Drawing.Point(369, 181);
            this.btnSCircular.Name = "btnSCircular";
            this.btnSCircular.Size = new System.Drawing.Size(154, 66);
            this.btnSCircular.TabIndex = 3;
            this.btnSCircular.Text = "Lista Simple Circular";
            this.btnSCircular.UseVisualStyleBackColor = false;
            this.btnSCircular.Click += new System.EventHandler(this.btnSCircular_Click);
            // 
            // btnDoble
            // 
            this.btnDoble.BackColor = System.Drawing.Color.Snow;
            this.btnDoble.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.btnDoble.ForeColor = System.Drawing.Color.Firebrick;
            this.btnDoble.Location = new System.Drawing.Point(133, 286);
            this.btnDoble.Name = "btnDoble";
            this.btnDoble.Size = new System.Drawing.Size(154, 66);
            this.btnDoble.TabIndex = 4;
            this.btnDoble.Text = "Lista Doble";
            this.btnDoble.UseVisualStyleBackColor = false;
            this.btnDoble.Click += new System.EventHandler(this.btnDoble_Click);
            // 
            // btnDCircular
            // 
            this.btnDCircular.BackColor = System.Drawing.Color.Snow;
            this.btnDCircular.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.btnDCircular.ForeColor = System.Drawing.Color.Firebrick;
            this.btnDCircular.Location = new System.Drawing.Point(369, 286);
            this.btnDCircular.Name = "btnDCircular";
            this.btnDCircular.Size = new System.Drawing.Size(154, 66);
            this.btnDCircular.TabIndex = 5;
            this.btnDCircular.Text = "Lista Doble Circular";
            this.btnDCircular.UseVisualStyleBackColor = false;
            this.btnDCircular.Click += new System.EventHandler(this.btnDCircular_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Snow;
            this.btnMenu.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnMenu.ForeColor = System.Drawing.Color.Firebrick;
            this.btnMenu.Location = new System.Drawing.Point(534, 392);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(107, 53);
            this.btnMenu.TabIndex = 6;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // MenuListas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoFinalCsharp.Properties.Resources.MenuListas;
            this.ClientSize = new System.Drawing.Size(730, 464);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnDCircular);
            this.Controls.Add(this.btnDoble);
            this.Controls.Add(this.btnSCircular);
            this.Controls.Add(this.btnSimple);
            this.Controls.Add(this.lblInstruccion);
            this.Controls.Add(this.lblListas);
            this.Name = "MenuListas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuListas_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblListas;
        private System.Windows.Forms.Label lblInstruccion;
        private System.Windows.Forms.Button btnSimple;
        private System.Windows.Forms.Button btnSCircular;
        private System.Windows.Forms.Button btnDoble;
        private System.Windows.Forms.Button btnDCircular;
        private System.Windows.Forms.Button btnMenu;
    }
}