namespace ProjetoCalculos
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalculadora = new System.Windows.Forms.Button();
            this.btnMedia = new System.Windows.Forms.Button();
            this.btnMediaP = new System.Windows.Forms.Button();
            this.btnIMC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalculadora
            // 
            this.btnCalculadora.Location = new System.Drawing.Point(50, 54);
            this.btnCalculadora.Name = "btnCalculadora";
            this.btnCalculadora.Size = new System.Drawing.Size(109, 49);
            this.btnCalculadora.TabIndex = 0;
            this.btnCalculadora.Text = "Calculadora";
            this.btnCalculadora.UseVisualStyleBackColor = true;
            this.btnCalculadora.Click += new System.EventHandler(this.btnCalculadora_Click);
            // 
            // btnMedia
            // 
            this.btnMedia.Location = new System.Drawing.Point(215, 54);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(109, 49);
            this.btnMedia.TabIndex = 1;
            this.btnMedia.Text = "Média";
            this.btnMedia.UseVisualStyleBackColor = true;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // btnMediaP
            // 
            this.btnMediaP.Location = new System.Drawing.Point(50, 133);
            this.btnMediaP.Name = "btnMediaP";
            this.btnMediaP.Size = new System.Drawing.Size(109, 49);
            this.btnMediaP.TabIndex = 2;
            this.btnMediaP.Text = "Média Ponderada";
            this.btnMediaP.UseVisualStyleBackColor = true;
            this.btnMediaP.Click += new System.EventHandler(this.btnMediaP_Click);
            // 
            // btnIMC
            // 
            this.btnIMC.Location = new System.Drawing.Point(215, 133);
            this.btnIMC.Name = "btnIMC";
            this.btnIMC.Size = new System.Drawing.Size(109, 49);
            this.btnIMC.TabIndex = 3;
            this.btnIMC.Text = "IMC";
            this.btnIMC.UseVisualStyleBackColor = true;
            this.btnIMC.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(373, 238);
            this.Controls.Add(this.btnIMC);
            this.Controls.Add(this.btnMediaP);
            this.Controls.Add(this.btnMedia);
            this.Controls.Add(this.btnCalculadora);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculos";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnCalculadora;
        private Button btnMedia;
        private Button btnMediaP;
        private Button btnIMC;
    }
}