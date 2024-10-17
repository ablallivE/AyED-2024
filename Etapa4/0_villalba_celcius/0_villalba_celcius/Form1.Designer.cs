namespace _0_villalba_celcius
{
    partial class front
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
            this.gradoconverjente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gradof = new System.Windows.Forms.Label();
            this.gradoK = new System.Windows.Forms.Label();
            this.gragas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gragas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(226, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "GRADOS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gradoconverjente
            // 
            this.gradoconverjente.Location = new System.Drawing.Point(232, 155);
            this.gradoconverjente.Name = "gradoconverjente";
            this.gradoconverjente.Size = new System.Drawing.Size(128, 20);
            this.gradoconverjente.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ingrese los grados a calcular";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(75, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "fahrenheit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(379, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kelvin";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(257, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 68);
            this.button1.TabIndex = 5;
            this.button1.Text = "toca aca";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gradof
            // 
            this.gradof.AutoSize = true;
            this.gradof.Location = new System.Drawing.Point(133, 329);
            this.gradof.Name = "gradof";
            this.gradof.Size = new System.Drawing.Size(13, 13);
            this.gradof.TabIndex = 6;
            this.gradof.Text = "0";
            this.gradof.Visible = false;
            // 
            // gradoK
            // 
            this.gradoK.AutoSize = true;
            this.gradoK.Location = new System.Drawing.Point(424, 329);
            this.gradoK.Name = "gradoK";
            this.gradoK.Size = new System.Drawing.Size(13, 13);
            this.gradoK.TabIndex = 7;
            this.gradoK.Text = "0";
            this.gradoK.Visible = false;
            // 
            // gragas
            // 
            this.gragas.Image = global::_0_villalba_celcius.Properties.Resources.gragas;
            this.gragas.Location = new System.Drawing.Point(243, 296);
            this.gragas.Name = "gragas";
            this.gragas.Size = new System.Drawing.Size(100, 100);
            this.gragas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gragas.TabIndex = 8;
            this.gragas.TabStop = false;
            this.gragas.Visible = false;
            // 
            // front
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(562, 411);
            this.Controls.Add(this.gragas);
            this.Controls.Add(this.gradoK);
            this.Controls.Add(this.gradof);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gradoconverjente);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "front";
            this.Text = "celcius";
            ((System.ComponentModel.ISupportInitialize)(this.gragas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox gradoconverjente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label gradof;
        private System.Windows.Forms.Label gradoK;
        private System.Windows.Forms.PictureBox gragas;
    }
}

