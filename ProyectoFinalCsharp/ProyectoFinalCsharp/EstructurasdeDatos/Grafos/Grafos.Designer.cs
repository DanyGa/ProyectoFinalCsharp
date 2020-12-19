namespace ProyectoFinalCsharp.EstructurasdeDatos.Grafos
{
    partial class Grafos
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grafo1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grafo1ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grafo1ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.moverTodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moverNodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aristaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dirigidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noDirigidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.matrizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adyacenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grafo1ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.pesoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grafo1ToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Snow;
            this.pictureBox1.Location = new System.Drawing.Point(16, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1035, 491);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.menuStrip1.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.nodoToolStripMenuItem,
            this.aristaToolStripMenuItem,
            this.matrizToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.BackColor = System.Drawing.Color.MediumTurquoise;
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.borrarToolStripMenuItem});
            this.archivoToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(91, 26);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.BackColor = System.Drawing.Color.Snow;
            this.nuevoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grafo1ToolStripMenuItem});
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // grafo1ToolStripMenuItem
            // 
            this.grafo1ToolStripMenuItem.BackColor = System.Drawing.Color.Snow;
            this.grafo1ToolStripMenuItem.Name = "grafo1ToolStripMenuItem";
            this.grafo1ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.grafo1ToolStripMenuItem.Text = "Grafo 1";
            this.grafo1ToolStripMenuItem.Click += new System.EventHandler(this.grafo1ToolStripMenuItem_Click);
            // 
            // borrarToolStripMenuItem
            // 
            this.borrarToolStripMenuItem.BackColor = System.Drawing.Color.Snow;
            this.borrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grafo1ToolStripMenuItem1});
            this.borrarToolStripMenuItem.Name = "borrarToolStripMenuItem";
            this.borrarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.borrarToolStripMenuItem.Text = "Borrar";
            // 
            // grafo1ToolStripMenuItem1
            // 
            this.grafo1ToolStripMenuItem1.BackColor = System.Drawing.Color.Snow;
            this.grafo1ToolStripMenuItem1.Name = "grafo1ToolStripMenuItem1";
            this.grafo1ToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.grafo1ToolStripMenuItem1.Text = "Grafo 1";
            this.grafo1ToolStripMenuItem1.Click += new System.EventHandler(this.grafo1ToolStripMenuItem1_Click);
            // 
            // nodoToolStripMenuItem
            // 
            this.nodoToolStripMenuItem.BackColor = System.Drawing.Color.MediumTurquoise;
            this.nodoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.moverTodoToolStripMenuItem,
            this.moverNodoToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.nodoToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.nodoToolStripMenuItem.Name = "nodoToolStripMenuItem";
            this.nodoToolStripMenuItem.Size = new System.Drawing.Size(69, 26);
            this.nodoToolStripMenuItem.Text = "Nodo";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.BackColor = System.Drawing.Color.Snow;
            this.agregarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grafo1ToolStripMenuItem2});
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.agregarToolStripMenuItem.Text = "Agregar";
            // 
            // grafo1ToolStripMenuItem2
            // 
            this.grafo1ToolStripMenuItem2.BackColor = System.Drawing.Color.Snow;
            this.grafo1ToolStripMenuItem2.Name = "grafo1ToolStripMenuItem2";
            this.grafo1ToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.grafo1ToolStripMenuItem2.Text = "Grafo 1";
            this.grafo1ToolStripMenuItem2.Click += new System.EventHandler(this.grafo1ToolStripMenuItem2_Click);
            // 
            // moverTodoToolStripMenuItem
            // 
            this.moverTodoToolStripMenuItem.BackColor = System.Drawing.Color.Snow;
            this.moverTodoToolStripMenuItem.Name = "moverTodoToolStripMenuItem";
            this.moverTodoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.moverTodoToolStripMenuItem.Text = "Mover Todo";
            this.moverTodoToolStripMenuItem.Click += new System.EventHandler(this.moverTodoToolStripMenuItem_Click);
            // 
            // moverNodoToolStripMenuItem
            // 
            this.moverNodoToolStripMenuItem.BackColor = System.Drawing.Color.Snow;
            this.moverNodoToolStripMenuItem.Name = "moverNodoToolStripMenuItem";
            this.moverNodoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.moverNodoToolStripMenuItem.Text = "Mover Nodo";
            this.moverNodoToolStripMenuItem.Click += new System.EventHandler(this.moverNodoToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.BackColor = System.Drawing.Color.Snow;
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // aristaToolStripMenuItem
            // 
            this.aristaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dirigidaToolStripMenuItem,
            this.noDirigidaToolStripMenuItem,
            this.eliminarToolStripMenuItem1});
            this.aristaToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.aristaToolStripMenuItem.Name = "aristaToolStripMenuItem";
            this.aristaToolStripMenuItem.Size = new System.Drawing.Size(77, 26);
            this.aristaToolStripMenuItem.Text = "Arista";
            // 
            // dirigidaToolStripMenuItem
            // 
            this.dirigidaToolStripMenuItem.BackColor = System.Drawing.Color.Snow;
            this.dirigidaToolStripMenuItem.Name = "dirigidaToolStripMenuItem";
            this.dirigidaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dirigidaToolStripMenuItem.Text = "Dirigida";
            this.dirigidaToolStripMenuItem.Click += new System.EventHandler(this.dirigidaToolStripMenuItem_Click);
            // 
            // noDirigidaToolStripMenuItem
            // 
            this.noDirigidaToolStripMenuItem.BackColor = System.Drawing.Color.Snow;
            this.noDirigidaToolStripMenuItem.Name = "noDirigidaToolStripMenuItem";
            this.noDirigidaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.noDirigidaToolStripMenuItem.Text = "No Dirigida";
            this.noDirigidaToolStripMenuItem.Click += new System.EventHandler(this.noDirigidaToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem1
            // 
            this.eliminarToolStripMenuItem1.BackColor = System.Drawing.Color.Snow;
            this.eliminarToolStripMenuItem1.Name = "eliminarToolStripMenuItem1";
            this.eliminarToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.eliminarToolStripMenuItem1.Text = "Eliminar";
            this.eliminarToolStripMenuItem1.Click += new System.EventHandler(this.eliminarToolStripMenuItem1_Click);
            // 
            // matrizToolStripMenuItem
            // 
            this.matrizToolStripMenuItem.BackColor = System.Drawing.Color.MediumTurquoise;
            this.matrizToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adyacenciaToolStripMenuItem,
            this.pesoToolStripMenuItem});
            this.matrizToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.matrizToolStripMenuItem.Name = "matrizToolStripMenuItem";
            this.matrizToolStripMenuItem.Size = new System.Drawing.Size(80, 26);
            this.matrizToolStripMenuItem.Text = "Matriz";
            // 
            // adyacenciaToolStripMenuItem
            // 
            this.adyacenciaToolStripMenuItem.BackColor = System.Drawing.Color.Snow;
            this.adyacenciaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grafo1ToolStripMenuItem3});
            this.adyacenciaToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.adyacenciaToolStripMenuItem.Name = "adyacenciaToolStripMenuItem";
            this.adyacenciaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.adyacenciaToolStripMenuItem.Text = "Adyacencia";
            // 
            // grafo1ToolStripMenuItem3
            // 
            this.grafo1ToolStripMenuItem3.BackColor = System.Drawing.Color.Snow;
            this.grafo1ToolStripMenuItem3.Name = "grafo1ToolStripMenuItem3";
            this.grafo1ToolStripMenuItem3.Size = new System.Drawing.Size(224, 26);
            this.grafo1ToolStripMenuItem3.Text = "Grafo 1";
            this.grafo1ToolStripMenuItem3.Click += new System.EventHandler(this.grafo1ToolStripMenuItem3_Click);
            // 
            // pesoToolStripMenuItem
            // 
            this.pesoToolStripMenuItem.BackColor = System.Drawing.Color.Snow;
            this.pesoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grafo1ToolStripMenuItem4});
            this.pesoToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.pesoToolStripMenuItem.Name = "pesoToolStripMenuItem";
            this.pesoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pesoToolStripMenuItem.Text = "Peso";
            // 
            // grafo1ToolStripMenuItem4
            // 
            this.grafo1ToolStripMenuItem4.BackColor = System.Drawing.Color.Snow;
            this.grafo1ToolStripMenuItem4.Name = "grafo1ToolStripMenuItem4";
            this.grafo1ToolStripMenuItem4.Size = new System.Drawing.Size(224, 26);
            this.grafo1ToolStripMenuItem4.Text = "Grafo 1";
            this.grafo1ToolStripMenuItem4.Click += new System.EventHandler(this.grafo1ToolStripMenuItem4_Click);
            // 
            // Grafos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Grafos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grafos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Grafos_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grafo1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grafo1ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grafo1ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem moverTodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moverNodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aristaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dirigidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noDirigidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem matrizToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adyacenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grafo1ToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem pesoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grafo1ToolStripMenuItem4;
    }
}