namespace ProyectoFinalCsharp
{
    partial class MenuAlgoritmos
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblIns = new System.Windows.Forms.Label();
            this.btnBubble = new System.Windows.Forms.Button();
            this.btnCocktail = new System.Windows.Forms.Button();
            this.btnCounting = new System.Windows.Forms.Button();
            this.btnShell = new System.Windows.Forms.Button();
            this.btnInsertion = new System.Windows.Forms.Button();
            this.btnRadix = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Snow;
            this.lblTitulo.Font = new System.Drawing.Font("Elephant", 25.8F);
            this.lblTitulo.ForeColor = System.Drawing.Color.Crimson;
            this.lblTitulo.Location = new System.Drawing.Point(38, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(644, 55);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Algoritmos de Ordenamiento";
            // 
            // lblIns
            // 
            this.lblIns.AutoSize = true;
            this.lblIns.BackColor = System.Drawing.Color.Snow;
            this.lblIns.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblIns.ForeColor = System.Drawing.Color.Crimson;
            this.lblIns.Location = new System.Drawing.Point(166, 74);
            this.lblIns.Name = "lblIns";
            this.lblIns.Size = new System.Drawing.Size(406, 30);
            this.lblIns.TabIndex = 1;
            this.lblIns.Text = "Selecciona un tipo de Algoritmo";
            // 
            // btnBubble
            // 
            this.btnBubble.BackColor = System.Drawing.Color.Snow;
            this.btnBubble.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.btnBubble.ForeColor = System.Drawing.Color.Crimson;
            this.btnBubble.Location = new System.Drawing.Point(97, 171);
            this.btnBubble.Name = "btnBubble";
            this.btnBubble.Size = new System.Drawing.Size(167, 67);
            this.btnBubble.TabIndex = 2;
            this.btnBubble.Text = "Bubble Sort";
            this.btnBubble.UseVisualStyleBackColor = false;
            this.btnBubble.Click += new System.EventHandler(this.btnBubble_Click);
            // 
            // btnCocktail
            // 
            this.btnCocktail.BackColor = System.Drawing.Color.Snow;
            this.btnCocktail.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.btnCocktail.ForeColor = System.Drawing.Color.Crimson;
            this.btnCocktail.Location = new System.Drawing.Point(97, 259);
            this.btnCocktail.Name = "btnCocktail";
            this.btnCocktail.Size = new System.Drawing.Size(167, 67);
            this.btnCocktail.TabIndex = 3;
            this.btnCocktail.Text = "Cocktail Sort";
            this.btnCocktail.UseVisualStyleBackColor = false;
            this.btnCocktail.Click += new System.EventHandler(this.btnCocktail_Click);
            // 
            // btnCounting
            // 
            this.btnCounting.BackColor = System.Drawing.Color.Snow;
            this.btnCounting.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.btnCounting.ForeColor = System.Drawing.Color.Crimson;
            this.btnCounting.Location = new System.Drawing.Point(285, 259);
            this.btnCounting.Name = "btnCounting";
            this.btnCounting.Size = new System.Drawing.Size(167, 67);
            this.btnCounting.TabIndex = 4;
            this.btnCounting.Text = "Counting Sort";
            this.btnCounting.UseVisualStyleBackColor = false;
            this.btnCounting.Click += new System.EventHandler(this.btnCounting_Click);
            // 
            // btnShell
            // 
            this.btnShell.BackColor = System.Drawing.Color.Snow;
            this.btnShell.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.btnShell.ForeColor = System.Drawing.Color.Crimson;
            this.btnShell.Location = new System.Drawing.Point(477, 259);
            this.btnShell.Name = "btnShell";
            this.btnShell.Size = new System.Drawing.Size(167, 67);
            this.btnShell.TabIndex = 5;
            this.btnShell.Text = "Shell Sort";
            this.btnShell.UseVisualStyleBackColor = false;
            this.btnShell.Click += new System.EventHandler(this.btnShell_Click);
            // 
            // btnInsertion
            // 
            this.btnInsertion.BackColor = System.Drawing.Color.Snow;
            this.btnInsertion.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.btnInsertion.ForeColor = System.Drawing.Color.Crimson;
            this.btnInsertion.Location = new System.Drawing.Point(285, 171);
            this.btnInsertion.Name = "btnInsertion";
            this.btnInsertion.Size = new System.Drawing.Size(167, 67);
            this.btnInsertion.TabIndex = 6;
            this.btnInsertion.Text = "Insertion Sort";
            this.btnInsertion.UseVisualStyleBackColor = false;
            this.btnInsertion.Click += new System.EventHandler(this.btnInsertion_Click);
            // 
            // btnRadix
            // 
            this.btnRadix.BackColor = System.Drawing.Color.Snow;
            this.btnRadix.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.btnRadix.ForeColor = System.Drawing.Color.Crimson;
            this.btnRadix.Location = new System.Drawing.Point(477, 171);
            this.btnRadix.Name = "btnRadix";
            this.btnRadix.Size = new System.Drawing.Size(167, 67);
            this.btnRadix.TabIndex = 7;
            this.btnRadix.Text = "Radix Sort";
            this.btnRadix.UseVisualStyleBackColor = false;
            this.btnRadix.Click += new System.EventHandler(this.btnRadix_Click);
            // 
            // MenuAlgoritmos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoFinalCsharp.Properties.Resources.MenuAlgoritmos;
            this.ClientSize = new System.Drawing.Size(784, 404);
            this.Controls.Add(this.btnRadix);
            this.Controls.Add(this.btnInsertion);
            this.Controls.Add(this.btnShell);
            this.Controls.Add(this.btnCounting);
            this.Controls.Add(this.btnCocktail);
            this.Controls.Add(this.btnBubble);
            this.Controls.Add(this.lblIns);
            this.Controls.Add(this.lblTitulo);
            this.Name = "MenuAlgoritmos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Algoritmos de Ordenamiento";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuAlgoritmos_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblIns;
        private System.Windows.Forms.Button btnBubble;
        private System.Windows.Forms.Button btnCocktail;
        private System.Windows.Forms.Button btnCounting;
        private System.Windows.Forms.Button btnShell;
        private System.Windows.Forms.Button btnInsertion;
        private System.Windows.Forms.Button btnRadix;
    }
}