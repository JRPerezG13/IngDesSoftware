namespace Actividad2
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saludoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosPersonalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesBásicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saludoToolStripMenuItem,
            this.datosPersonalesToolStripMenuItem,
            this.operacionesBásicasToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0, 40, 0, 10);
            this.menuStrip1.Size = new System.Drawing.Size(176, 407);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // saludoToolStripMenuItem
            // 
            this.saludoToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saludoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saludoToolStripMenuItem.Name = "saludoToolStripMenuItem";
            this.saludoToolStripMenuItem.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.saludoToolStripMenuItem.Size = new System.Drawing.Size(175, 45);
            this.saludoToolStripMenuItem.Text = "Saludo";
            this.saludoToolStripMenuItem.Click += new System.EventHandler(this.saludoToolStripMenuItem_Click_1);
            // 
            // datosPersonalesToolStripMenuItem
            // 
            this.datosPersonalesToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datosPersonalesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.datosPersonalesToolStripMenuItem.Name = "datosPersonalesToolStripMenuItem";
            this.datosPersonalesToolStripMenuItem.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.datosPersonalesToolStripMenuItem.Size = new System.Drawing.Size(175, 45);
            this.datosPersonalesToolStripMenuItem.Text = "Datos personales";
            this.datosPersonalesToolStripMenuItem.Click += new System.EventHandler(this.datosPersonalesToolStripMenuItem_Click);
            // 
            // operacionesBásicasToolStripMenuItem
            // 
            this.operacionesBásicasToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operacionesBásicasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.operacionesBásicasToolStripMenuItem.Name = "operacionesBásicasToolStripMenuItem";
            this.operacionesBásicasToolStripMenuItem.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.operacionesBásicasToolStripMenuItem.Size = new System.Drawing.Size(175, 45);
            this.operacionesBásicasToolStripMenuItem.Text = "Operaciones básicas";
            this.operacionesBásicasToolStripMenuItem.Click += new System.EventHandler(this.operacionesBásicasToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salirToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(175, 45);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(202, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(436, 366);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 407);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saludoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosPersonalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionesBásicasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

