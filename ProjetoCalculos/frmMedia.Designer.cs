namespace ProjetoCalculos
{
    partial class frmMedia
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
            this.btnResultado = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblSinal = new System.Windows.Forms.Label();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.txtValor3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnResultado
            // 
            this.btnResultado.Location = new System.Drawing.Point(49, 86);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(61, 23);
            this.btnResultado.TabIndex = 36;
            this.btnResultado.Text = "=";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(210, 150);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(61, 29);
            this.btnVoltar.TabIndex = 30;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(49, 119);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(61, 24);
            this.btnLimpar.TabIndex = 26;
            this.btnLimpar.Text = "C";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblSinal
            // 
            this.lblSinal.AutoSize = true;
            this.lblSinal.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblSinal.Location = new System.Drawing.Point(75, 46);
            this.lblSinal.Name = "lblSinal";
            this.lblSinal.Size = new System.Drawing.Size(0, 15);
            this.lblSinal.TabIndex = 19;
            // 
            // txtValor1
            // 
            this.txtValor1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtValor1.Location = new System.Drawing.Point(49, 57);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(61, 23);
            this.txtValor1.TabIndex = 20;
            // 
            // txtValor2
            // 
            this.txtValor2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtValor2.Location = new System.Drawing.Point(130, 57);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(61, 23);
            this.txtValor2.TabIndex = 37;
            // 
            // txtValor3
            // 
            this.txtValor3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtValor3.Location = new System.Drawing.Point(210, 57);
            this.txtValor3.Name = "txtValor3";
            this.txtValor3.Size = new System.Drawing.Size(61, 23);
            this.txtValor3.TabIndex = 38;
            this.txtValor3.TextChanged += new System.EventHandler(this.txtValor3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 39;
            this.label1.Text = "Valor 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 40;
            this.label2.Text = "Valor 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 41;
            this.label3.Text = "Valor 3";
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtResultado.Enabled = false;
            this.txtResultado.Location = new System.Drawing.Point(130, 86);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(141, 23);
            this.txtResultado.TabIndex = 42;
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(318, 204);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValor3);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblSinal);
            this.Controls.Add(this.txtValor1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMedia";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Media";
            this.Load += new System.EventHandler(this.frmMedia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnResultado;
        private Button btnVoltar;
        private Button btnLimpar;
        private Label lblSinal;
        private TextBox txtValor1;
        private TextBox txtValor2;
        private TextBox txtValor3;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtResultado;
    }
}