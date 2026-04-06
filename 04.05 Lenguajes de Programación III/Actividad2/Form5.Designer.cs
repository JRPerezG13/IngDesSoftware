namespace Actividad2
{
    partial class flogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(flogin));
            this.label1 = new System.Windows.Forms.Label();
            this.contra = new System.Windows.Forms.TextBox();
            this.botingresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(28, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contraseña para inicio de sesión";
            // 
            // contra
            // 
            this.contra.Location = new System.Drawing.Point(170, 40);
            this.contra.Name = "contra";
            this.contra.PasswordChar = '*';
            this.contra.Size = new System.Drawing.Size(129, 28);
            this.contra.TabIndex = 1;
            // 
            // botingresar
            // 
            this.botingresar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.botingresar.ForeColor = System.Drawing.SystemColors.Control;
            this.botingresar.Location = new System.Drawing.Point(79, 106);
            this.botingresar.Name = "botingresar";
            this.botingresar.Size = new System.Drawing.Size(171, 34);
            this.botingresar.TabIndex = 2;
            this.botingresar.Text = "Entrar";
            this.botingresar.UseVisualStyleBackColor = false;
            this.botingresar.Click += new System.EventHandler(this.botingresar_Click);
            // 
            // flogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(325, 196);
            this.Controls.Add(this.botingresar);
            this.Controls.Add(this.contra);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "flogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox contra;
        private System.Windows.Forms.Button botingresar;
    }
}