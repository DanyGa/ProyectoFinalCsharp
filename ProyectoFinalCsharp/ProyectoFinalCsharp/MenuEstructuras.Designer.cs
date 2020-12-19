namespace ProyectoFinalCsharp
{
    partial class MenuEstructuras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuEstructuras));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPila = new System.Windows.Forms.Button();
            this.btnCola = new System.Windows.Forms.Button();
            this.btnListas = new System.Windows.Forms.Button();
            this.btnGrafo = new System.Windows.Forms.Button();
            this.btnArbol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Snow;
            this.lblTitulo.Font = new System.Drawing.Font("Elephant", 25.8F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.Olive;
            this.lblTitulo.Location = new System.Drawing.Point(115, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(505, 55);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Estructuras de Datos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Snow;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Olive;
            this.label2.Location = new System.Drawing.Point(166, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(414, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Selecciona un tipo de Estructura\r\n";
            // 
            // btnPila
            // 
            this.btnPila.BackColor = System.Drawing.Color.Snow;
            this.btnPila.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.btnPila.ForeColor = System.Drawing.Color.Olive;
            this.btnPila.Location = new System.Drawing.Point(294, 176);
            this.btnPila.Name = "btnPila";
            this.btnPila.Size = new System.Drawing.Size(167, 67);
            this.btnPila.TabIndex = 2;
            this.btnPila.Text = "Pila";
            this.btnPila.UseVisualStyleBackColor = false;
            this.btnPila.Click += new System.EventHandler(this.btnPila_Click);
            // 
            // btnCola
            // 
            this.btnCola.BackColor = System.Drawing.Color.Snow;
            this.btnCola.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.btnCola.ForeColor = System.Drawing.Color.Olive;
            this.btnCola.Location = new System.Drawing.Point(533, 176);
            this.btnCola.Name = "btnCola";
            this.btnCola.Size = new System.Drawing.Size(167, 67);
            this.btnCola.TabIndex = 3;
            this.btnCola.Text = "Cola";
            this.btnCola.UseVisualStyleBackColor = false;
            this.btnCola.Click += new System.EventHandler(this.btnCola_Click);
            // 
            // btnListas
            // 
            this.btnListas.BackColor = System.Drawing.Color.Snow;
            this.btnListas.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.btnListas.ForeColor = System.Drawing.Color.Olive;
            this.btnListas.Location = new System.Drawing.Point(56, 176);
            this.btnListas.Name = "btnListas";
            this.btnListas.Size = new System.Drawing.Size(167, 67);
            this.btnListas.TabIndex = 4;
            this.btnListas.Text = "Listas";
            this.btnListas.UseVisualStyleBackColor = false;
            this.btnListas.Click += new System.EventHandler(this.btnListas_Click);
            // 
            // btnGrafo
            // 
            this.btnGrafo.BackColor = System.Drawing.Color.Snow;
            this.btnGrafo.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.btnGrafo.ForeColor = System.Drawing.Color.Olive;
            this.btnGrafo.Location = new System.Drawing.Point(162, 314);
            this.btnGrafo.Name = "btnGrafo";
            this.btnGrafo.Size = new System.Drawing.Size(167, 67);
            this.btnGrafo.TabIndex = 5;
            this.btnGrafo.Text = "Grafo";
            this.btnGrafo.UseVisualStyleBackColor = false;
            this.btnGrafo.Click += new System.EventHandler(this.btnGrafo_Click);
            // 
            // btnArbol
            // 
            this.btnArbol.BackColor = System.Drawing.Color.Snow;
            this.btnArbol.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.btnArbol.ForeColor = System.Drawing.Color.Olive;
            this.btnArbol.Location = new System.Drawing.Point(422, 314);
            this.btnArbol.Name = "btnArbol";
            this.btnArbol.Size = new System.Drawing.Size(167, 67);
            this.btnArbol.TabIndex = 6;
            this.btnArbol.Text = "Arbol";
            this.btnArbol.UseVisualStyleBackColor = false;
            this.btnArbol.Click += new System.EventHandler(this.btnArbol_Click);
            // 
            // MenuEstructuras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 485);
            this.Controls.Add(this.btnArbol);
            this.Controls.Add(this.btnGrafo);
            this.Controls.Add(this.btnListas);
            this.Controls.Add(this.btnCola);
            this.Controls.Add(this.btnPila);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitulo);
            this.Name = "MenuEstructuras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructuras de Datos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuEstructuras_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPila;
        private System.Windows.Forms.Button btnCola;
        private System.Windows.Forms.Button btnListas;
        private System.Windows.Forms.Button btnGrafo;
        private System.Windows.Forms.Button btnArbol;
    }
}