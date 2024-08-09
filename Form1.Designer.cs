namespace repasoJuaniFinalVargui
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
            this.cbGustos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbFrutales = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // cbGustos
            // 
            this.cbGustos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGustos.FormattingEnabled = true;
            this.cbGustos.Location = new System.Drawing.Point(53, 6);
            this.cbGustos.Name = "cbGustos";
            this.cbGustos.Size = new System.Drawing.Size(255, 21);
            this.cbGustos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // rbFrutales
            // 
            this.rbFrutales.AutoSize = true;
            this.rbFrutales.Location = new System.Drawing.Point(314, 12);
            this.rbFrutales.Name = "rbFrutales";
            this.rbFrutales.Size = new System.Drawing.Size(85, 17);
            this.rbFrutales.TabIndex = 2;
            this.rbFrutales.TabStop = true;
            this.rbFrutales.Text = "radioButton1";
            this.rbFrutales.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(314, 47);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 336);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.rbFrutales);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbGustos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbGustos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbFrutales;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}

