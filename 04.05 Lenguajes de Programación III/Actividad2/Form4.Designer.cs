namespace Actividad2
{
    partial class Saludo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Saludo));
            this.label1 = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.TextBox();
            this.BotSal1 = new System.Windows.Forms.Button();
            this.BotSal2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(60, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresa tu nombre:";
            // 
            // nom
            // 
            this.nom.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom.Location = new System.Drawing.Point(46, 65);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(183, 28);
            this.nom.TabIndex = 1;
            // 
            // BotSal1
            // 
            this.BotSal1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BotSal1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotSal1.Location = new System.Drawing.Point(46, 115);
            this.BotSal1.Name = "BotSal1";
            this.BotSal1.Size = new System.Drawing.Size(91, 36);
            this.BotSal1.TabIndex = 2;
            this.BotSal1.Text = "Saludar";
            this.BotSal1.UseVisualStyleBackColor = false;
            this.BotSal1.Click += new System.EventHandler(this.BotSal1_Click);
            // 
            // BotSal2
            // 
            this.BotSal2.BackColor = System.Drawing.Color.Silver;
            this.BotSal2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotSal2.Location = new System.Drawing.Point(138, 115);
            this.BotSal2.Name = "BotSal2";
            this.BotSal2.Size = new System.Drawing.Size(91, 36);
            this.BotSal2.TabIndex = 3;
            this.BotSal2.Text = "Regresar";
            this.BotSal2.UseVisualStyleBackColor = false;
            this.BotSal2.Click += new System.EventHandler(this.BotSal2_Click);
            // 
            // Saludo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(278, 190);
            this.Controls.Add(this.BotSal2);
            this.Controls.Add(this.BotSal1);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Saludo";
            this.Text = "Saludo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.Button BotSal1;
        private System.Windows.Forms.Button BotSal2;
    }
}