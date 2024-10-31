namespace _4_villalba_mipj
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.vida = new System.Windows.Forms.TextBox();
            this.Raza = new System.Windows.Forms.ComboBox();
            this.Habil = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "crear personaje";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(184, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "raza";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(184, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(184, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "habilidades extras";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(184, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "vida";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(188, 97);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(201, 20);
            this.name.TabIndex = 5;
            // 
            // vida
            // 
            this.vida.Location = new System.Drawing.Point(188, 173);
            this.vida.Name = "vida";
            this.vida.Size = new System.Drawing.Size(201, 20);
            this.vida.TabIndex = 6;
            // 
            // Raza
            // 
            this.Raza.FormattingEnabled = true;
            this.Raza.Items.AddRange(new object[] {
            "Humano",
            "Enano",
            "Hobbit"});
            this.Raza.Location = new System.Drawing.Point(188, 246);
            this.Raza.Name = "Raza";
            this.Raza.Size = new System.Drawing.Size(201, 21);
            this.Raza.TabIndex = 7;
            // 
            // Habil
            // 
            this.Habil.BackColor = System.Drawing.SystemColors.Control;
            this.Habil.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Habil.CheckOnClick = true;
            this.Habil.FormattingEnabled = true;
            this.Habil.Items.AddRange(new object[] {
            "Fuerza sobrehumana",
            "Invisibilidad",
            "Curacion rapida"});
            this.Habil.Location = new System.Drawing.Point(188, 315);
            this.Habil.Name = "Habil";
            this.Habil.Size = new System.Drawing.Size(201, 90);
            this.Habil.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(234, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 59);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(458, 382);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 59);
            this.button2.TabIndex = 10;
            this.button2.Text = "off";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 453);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Habil);
            this.Controls.Add(this.Raza);
            this.Controls.Add(this.vida);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox vida;
        private System.Windows.Forms.ComboBox Raza;
        private System.Windows.Forms.CheckedListBox Habil;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

