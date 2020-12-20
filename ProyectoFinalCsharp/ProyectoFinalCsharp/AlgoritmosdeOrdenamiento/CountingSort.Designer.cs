namespace ProyectoFinalCsharp.AlgoritmosdeOrdenamiento
{
    partial class CountingSort
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
            this.lblNum = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gbTiempo = new System.Windows.Forms.GroupBox();
            this.lblOrdenar = new System.Windows.Forms.Label();
            this.lblOrd = new System.Windows.Forms.Label();
            this.lbNum = new System.Windows.Forms.ListBox();
            this.lbOrd = new System.Windows.Forms.ListBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.gbTiempo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.BackColor = System.Drawing.Color.Snow;
            this.lblNum.Font = new System.Drawing.Font("Britannic Bold", 13.8F);
            this.lblNum.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblNum.Location = new System.Drawing.Point(62, 130);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(113, 27);
            this.lblNum.TabIndex = 0;
            this.lblNum.Text = "Numeros:";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.BackColor = System.Drawing.Color.Snow;
            this.lblMin.Font = new System.Drawing.Font("Britannic Bold", 13.8F);
            this.lblMin.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblMin.Location = new System.Drawing.Point(62, 176);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(171, 27);
            this.lblMin.TabIndex = 1;
            this.lblMin.Text = "Limite Minimo:";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.BackColor = System.Drawing.Color.Snow;
            this.lblMax.Font = new System.Drawing.Font("Britannic Bold", 13.8F);
            this.lblMax.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblMax.Location = new System.Drawing.Point(62, 223);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(174, 27);
            this.lblMax.TabIndex = 2;
            this.lblMax.Text = "Limite Maximo:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Snow;
            this.lblTitulo.Font = new System.Drawing.Font("Elephant", 22.2F);
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblTitulo.Location = new System.Drawing.Point(282, 35);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(290, 49);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Counting Sort";
            // 
            // gbTiempo
            // 
            this.gbTiempo.BackColor = System.Drawing.Color.Snow;
            this.gbTiempo.Controls.Add(this.lblOrdenar);
            this.gbTiempo.Controls.Add(this.lblOrd);
            this.gbTiempo.Font = new System.Drawing.Font("Britannic Bold", 12F);
            this.gbTiempo.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.gbTiempo.Location = new System.Drawing.Point(23, 401);
            this.gbTiempo.Name = "gbTiempo";
            this.gbTiempo.Size = new System.Drawing.Size(410, 94);
            this.gbTiempo.TabIndex = 4;
            this.gbTiempo.TabStop = false;
            // 
            // lblOrdenar
            // 
            this.lblOrdenar.AutoSize = true;
            this.lblOrdenar.Location = new System.Drawing.Point(135, 37);
            this.lblOrdenar.Name = "lblOrdenar";
            this.lblOrdenar.Size = new System.Drawing.Size(40, 22);
            this.lblOrdenar.TabIndex = 1;
            this.lblOrdenar.Text = "0:0";
            // 
            // lblOrd
            // 
            this.lblOrd.AutoSize = true;
            this.lblOrd.Location = new System.Drawing.Point(19, 37);
            this.lblOrd.Name = "lblOrd";
            this.lblOrd.Size = new System.Drawing.Size(90, 22);
            this.lblOrd.TabIndex = 0;
            this.lblOrd.Text = "Ordenar:";
            // 
            // lbNum
            // 
            this.lbNum.BackColor = System.Drawing.Color.Snow;
            this.lbNum.Font = new System.Drawing.Font("Britannic Bold", 10.2F);
            this.lbNum.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lbNum.FormattingEnabled = true;
            this.lbNum.ItemHeight = 19;
            this.lbNum.Location = new System.Drawing.Point(494, 130);
            this.lbNum.Name = "lbNum";
            this.lbNum.Size = new System.Drawing.Size(110, 365);
            this.lbNum.TabIndex = 2;
            // 
            // lbOrd
            // 
            this.lbOrd.BackColor = System.Drawing.Color.Snow;
            this.lbOrd.Font = new System.Drawing.Font("Britannic Bold", 10.2F);
            this.lbOrd.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lbOrd.FormattingEnabled = true;
            this.lbOrd.ItemHeight = 19;
            this.lbOrd.Location = new System.Drawing.Point(647, 130);
            this.lbOrd.Name = "lbOrd";
            this.lbOrd.Size = new System.Drawing.Size(110, 365);
            this.lbOrd.TabIndex = 3;
            // 
            // txtNum
            // 
            this.txtNum.BackColor = System.Drawing.Color.Snow;
            this.txtNum.Font = new System.Drawing.Font("Britannic Bold", 10.2F);
            this.txtNum.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.txtNum.Location = new System.Drawing.Point(197, 135);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(181, 26);
            this.txtNum.TabIndex = 5;
            // 
            // txtMin
            // 
            this.txtMin.BackColor = System.Drawing.Color.Snow;
            this.txtMin.Font = new System.Drawing.Font("Britannic Bold", 10.2F);
            this.txtMin.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.txtMin.Location = new System.Drawing.Point(262, 181);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(116, 26);
            this.txtMin.TabIndex = 6;
            // 
            // txtMax
            // 
            this.txtMax.BackColor = System.Drawing.Color.Snow;
            this.txtMax.Font = new System.Drawing.Font("Britannic Bold", 10.2F);
            this.txtMax.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.txtMax.Location = new System.Drawing.Point(262, 228);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(116, 26);
            this.txtMax.TabIndex = 7;
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.Snow;
            this.btnGenerar.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnGenerar.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnGenerar.Location = new System.Drawing.Point(66, 280);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(136, 69);
            this.btnGenerar.TabIndex = 8;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.BackColor = System.Drawing.Color.Snow;
            this.btnOrdenar.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnOrdenar.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnOrdenar.Location = new System.Drawing.Point(242, 280);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(136, 69);
            this.btnOrdenar.TabIndex = 9;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = false;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Snow;
            this.btnMenu.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnMenu.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnMenu.Location = new System.Drawing.Point(718, 521);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(107, 53);
            this.btnMenu.TabIndex = 10;
            this.btnMenu.Text = "Menu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // CountingSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoFinalCsharp.Properties.Resources.CountingSort;
            this.ClientSize = new System.Drawing.Size(851, 601);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.lbNum);
            this.Controls.Add(this.lbOrd);
            this.Controls.Add(this.gbTiempo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblNum);
            this.Name = "CountingSort";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Counting Sort";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CountingSort_FormClosed);
            this.gbTiempo.ResumeLayout(false);
            this.gbTiempo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gbTiempo;
        private System.Windows.Forms.Label lblOrdenar;
        private System.Windows.Forms.Label lblOrd;
        private System.Windows.Forms.ListBox lbNum;
        private System.Windows.Forms.ListBox lbOrd;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnMenu;
    }
}