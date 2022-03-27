namespace JogoDaForca
{
    partial class CustomMessageBox
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnSim = new System.Windows.Forms.Button();
            this.btnNao = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPalavra = new System.Windows.Forms.Label();
            this.lblPontos = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Ink Free", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(1, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Deseja jogar novamente?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSim
            // 
            this.btnSim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSim.BackColor = System.Drawing.Color.Transparent;
            this.btnSim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSim.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnSim.FlatAppearance.BorderSize = 2;
            this.btnSim.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnSim.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSim.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSim.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSim.ForeColor = System.Drawing.Color.Green;
            this.btnSim.Location = new System.Drawing.Point(373, 186);
            this.btnSim.Name = "btnSim";
            this.btnSim.Size = new System.Drawing.Size(60, 28);
            this.btnSim.TabIndex = 54;
            this.btnSim.TabStop = false;
            this.btnSim.Text = "SIM";
            this.btnSim.UseVisualStyleBackColor = false;
            this.btnSim.Click += new System.EventHandler(this.btnSim_Click);
            // 
            // btnNao
            // 
            this.btnNao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNao.BackColor = System.Drawing.Color.Transparent;
            this.btnNao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNao.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnNao.FlatAppearance.BorderSize = 2;
            this.btnNao.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnNao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnNao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnNao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNao.Font = new System.Drawing.Font("Ink Free", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNao.ForeColor = System.Drawing.Color.Red;
            this.btnNao.Location = new System.Drawing.Point(297, 186);
            this.btnNao.Name = "btnNao";
            this.btnNao.Size = new System.Drawing.Size(60, 28);
            this.btnNao.TabIndex = 55;
            this.btnNao.TabStop = false;
            this.btnNao.Text = "NÃO";
            this.btnNao.UseVisualStyleBackColor = false;
            this.btnNao.Click += new System.EventHandler(this.btnNao_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(3, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 23);
            this.label3.TabIndex = 56;
            this.label3.Text = "a palavra era:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(3, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 23);
            this.label4.TabIndex = 57;
            this.label4.Text = "seus pontos:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPalavra
            // 
            this.lblPalavra.AutoSize = true;
            this.lblPalavra.BackColor = System.Drawing.Color.Transparent;
            this.lblPalavra.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPalavra.Location = new System.Drawing.Point(132, 70);
            this.lblPalavra.Name = "lblPalavra";
            this.lblPalavra.Size = new System.Drawing.Size(79, 23);
            this.lblPalavra.TabIndex = 58;
            this.lblPalavra.Text = "palavra";
            this.lblPalavra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPontos
            // 
            this.lblPontos.AutoSize = true;
            this.lblPontos.BackColor = System.Drawing.Color.Transparent;
            this.lblPontos.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPontos.Location = new System.Drawing.Point(114, 104);
            this.lblPontos.Name = "lblPontos";
            this.lblPontos.Size = new System.Drawing.Size(68, 23);
            this.lblPontos.TabIndex = 59;
            this.lblPontos.Text = "pontos";
            this.lblPontos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblPontos);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblPalavra);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnSim);
            this.panel1.Controls.Add(this.btnNao);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 226);
            this.panel1.TabIndex = 61;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 38);
            this.label1.TabIndex = 60;
            this.label1.Text = "JOGO FINALIZADO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CustomMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(440, 228);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomMessageBox";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CustomMessageBox";
            this.Load += new System.EventHandler(this.CustomMessageBox_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSim;
        private System.Windows.Forms.Button btnNao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPalavra;
        private System.Windows.Forms.Label lblPontos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}