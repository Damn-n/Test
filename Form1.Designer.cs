namespace Test
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
            this.si = new System.Windows.Forms.Label();
            this.txtbutton = new System.Windows.Forms.Button();
            this.colorbutton = new System.Windows.Forms.Button();
            this.fontbutton = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // si
            // 
            this.si.AutoSize = true;
            this.si.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.si.Location = new System.Drawing.Point(250, 60);
            this.si.Name = "si";
            this.si.Size = new System.Drawing.Size(179, 36);
            this.si.TabIndex = 0;
            this.si.Text = "Buenos dias";
            this.si.Click += new System.EventHandler(this.NameTxt_Click);
            // 
            // txtbutton
            // 
            this.txtbutton.Location = new System.Drawing.Point(82, 120);
            this.txtbutton.Name = "txtbutton";
            this.txtbutton.Size = new System.Drawing.Size(136, 45);
            this.txtbutton.TabIndex = 1;
            this.txtbutton.Text = "Cambiar texto";
            this.txtbutton.UseVisualStyleBackColor = true;
            this.txtbutton.Click += new System.EventHandler(this.ChangeTxtButton_Click);
            // 
            // colorbutton
            // 
            this.colorbutton.Location = new System.Drawing.Point(458, 122);
            this.colorbutton.Name = "colorbutton";
            this.colorbutton.Size = new System.Drawing.Size(136, 41);
            this.colorbutton.TabIndex = 2;
            this.colorbutton.Text = "Cambiar color";
            this.colorbutton.UseVisualStyleBackColor = true;
            this.colorbutton.Click += new System.EventHandler(this.ColorBtn_Click);
            // 
            // fontbutton
            // 
            this.fontbutton.Location = new System.Drawing.Point(275, 201);
            this.fontbutton.Name = "fontbutton";
            this.fontbutton.Size = new System.Drawing.Size(136, 36);
            this.fontbutton.TabIndex = 3;
            this.fontbutton.Text = "Cambiar fuente";
            this.fontbutton.UseVisualStyleBackColor = true;
            this.fontbutton.Click += new System.EventHandler(this.FrontBtn_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(507, 319);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(72, 29);
            this.Reset.TabIndex = 4;
            this.Reset.Text = "Restablecer";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 407);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.fontbutton);
            this.Controls.Add(this.colorbutton);
            this.Controls.Add(this.txtbutton);
            this.Controls.Add(this.si);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label si;
        private System.Windows.Forms.Button txtbutton;
        private System.Windows.Forms.Button colorbutton;
        private System.Windows.Forms.Button fontbutton;
        private System.Windows.Forms.Button Reset;
    }
}

