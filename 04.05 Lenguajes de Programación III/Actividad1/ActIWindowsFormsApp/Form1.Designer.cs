namespace ActIWindowsFormsApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DatosPersonales = new System.Windows.Forms.GroupBox();
            this.nom = new System.Windows.Forms.TextBox();
            this.fecnac = new System.Windows.Forms.TextBox();
            this.dire = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mat = new System.Windows.Forms.RadioButton();
            this.vesp = new System.Windows.Forms.RadioButton();
            this.online = new System.Windows.Forms.RadioButton();
            this.estados = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Boton = new System.Windows.Forms.Button();
            this.DatosPersonales.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DatosPersonales
            // 
            this.DatosPersonales.Controls.Add(this.label3);
            this.DatosPersonales.Controls.Add(this.label2);
            this.DatosPersonales.Controls.Add(this.label1);
            this.DatosPersonales.Controls.Add(this.dire);
            this.DatosPersonales.Controls.Add(this.fecnac);
            this.DatosPersonales.Controls.Add(this.nom);
            this.DatosPersonales.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatosPersonales.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.DatosPersonales.Location = new System.Drawing.Point(12, 23);
            this.DatosPersonales.Name = "DatosPersonales";
            this.DatosPersonales.Size = new System.Drawing.Size(440, 271);
            this.DatosPersonales.TabIndex = 0;
            this.DatosPersonales.TabStop = false;
            this.DatosPersonales.Text = "Datos Personales:";
            // 
            // nom
            // 
            this.nom.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.nom.Location = new System.Drawing.Point(48, 65);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(358, 35);
            this.nom.TabIndex = 0;
            // 
            // fecnac
            // 
            this.fecnac.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.fecnac.Location = new System.Drawing.Point(48, 138);
            this.fecnac.Name = "fecnac";
            this.fecnac.Size = new System.Drawing.Size(358, 35);
            this.fecnac.TabIndex = 1;
            // 
            // dire
            // 
            this.dire.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dire.Location = new System.Drawing.Point(48, 210);
            this.dire.Name = "dire";
            this.dire.Size = new System.Drawing.Size(358, 35);
            this.dire.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(26, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre Completo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label2.Location = new System.Drawing.Point(26, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha de Nacimiento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label3.Location = new System.Drawing.Point(26, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dirección:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.online);
            this.groupBox1.Controls.Add(this.vesp);
            this.groupBox1.Controls.Add(this.mat);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Location = new System.Drawing.Point(467, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 270);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Horario deseado:";
            // 
            // mat
            // 
            this.mat.AutoSize = true;
            this.mat.ForeColor = System.Drawing.SystemColors.MenuText;
            this.mat.Location = new System.Drawing.Point(36, 42);
            this.mat.Name = "mat";
            this.mat.Size = new System.Drawing.Size(109, 26);
            this.mat.TabIndex = 0;
            this.mat.TabStop = true;
            this.mat.Text = "Matutino";
            this.mat.UseVisualStyleBackColor = true;
            // 
            // vesp
            // 
            this.vesp.AutoSize = true;
            this.vesp.ForeColor = System.Drawing.SystemColors.MenuText;
            this.vesp.Location = new System.Drawing.Point(36, 111);
            this.vesp.Name = "vesp";
            this.vesp.Size = new System.Drawing.Size(124, 26);
            this.vesp.TabIndex = 1;
            this.vesp.TabStop = true;
            this.vesp.Text = "Vespertino";
            this.vesp.UseVisualStyleBackColor = true;
            // 
            // online
            // 
            this.online.AutoSize = true;
            this.online.ForeColor = System.Drawing.SystemColors.MenuText;
            this.online.Location = new System.Drawing.Point(36, 183);
            this.online.Name = "online";
            this.online.Size = new System.Drawing.Size(104, 26);
            this.online.TabIndex = 2;
            this.online.TabStop = true;
            this.online.Text = "En Linea";
            this.online.UseVisualStyleBackColor = true;
            // 
            // estados
            // 
            this.estados.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.estados.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estados.FormattingEnabled = true;
            this.estados.ItemHeight = 17;
            this.estados.Items.AddRange(new object[] {
            "Aguascalientes",
            "Baja California",
            "Baja California Sur",
            "Campeche",
            "Chiapas",
            "Chihuahua",
            "Ciudad de México",
            "Coahuila de Zaragoza",
            "Colima",
            "Durango",
            "Estado de México",
            "Guanajuato",
            "Guerrero",
            "Hidalgo",
            "Jalisco",
            "Michoacán de Ocampo",
            "Morelos",
            "Nayarit",
            "Nuevo León",
            "Oaxaca",
            "Puebla",
            "Querétaro",
            "Quintana Roo",
            "San Luis Potosí",
            "Sinaloa",
            "Sonora",
            "Tabasco",
            "Tamaulipas",
            "Tlaxcala",
            "Veracruz de Ignacio de la Llave",
            "Yucatán"});
            this.estados.Location = new System.Drawing.Point(14, 331);
            this.estados.Name = "estados";
            this.estados.Size = new System.Drawing.Size(438, 123);
            this.estados.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Console", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(18, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Estado donde vives:";
            // 
            // Boton
            // 
            this.Boton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Boton.Font = new System.Drawing.Font("Lucida Console", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Boton.Location = new System.Drawing.Point(537, 354);
            this.Boton.Name = "Boton";
            this.Boton.Size = new System.Drawing.Size(176, 70);
            this.Boton.TabIndex = 7;
            this.Boton.Text = "Guardar";
            this.Boton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.Boton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.estados);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DatosPersonales);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Expediente de alumno";
            this.DatosPersonales.ResumeLayout(false);
            this.DatosPersonales.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox DatosPersonales;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dire;
        private System.Windows.Forms.TextBox fecnac;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton online;
        private System.Windows.Forms.RadioButton vesp;
        private System.Windows.Forms.RadioButton mat;
        private System.Windows.Forms.ListBox estados;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Boton;
    }
}

