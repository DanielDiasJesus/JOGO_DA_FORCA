namespace JogoDaForca
{
    partial class EscolherTema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EscolherTema));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPaises = new System.Windows.Forms.Button();
            this.btnProfissoes = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAnimais = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAlimentos = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(1000, 39);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "ESCOLHA UM TEMA";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnPaises, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnProfissoes, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnAnimais, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnAlimentos, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 39);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.1256F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.8744F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 184F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1000, 510);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Aquamarine;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(502, 440);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(491, 63);
            this.label4.TabIndex = 67;
            this.label4.Text = "PAÍSES";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.handlePaises);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(7, 440);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(491, 63);
            this.label3.TabIndex = 66;
            this.label3.Text = "PROFISSÕES";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.handleProfissoes);
            // 
            // btnPaises
            // 
            this.btnPaises.BackColor = System.Drawing.Color.Aquamarine;
            this.btnPaises.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPaises.BackgroundImage")));
            this.btnPaises.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPaises.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPaises.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPaises.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPaises.FlatAppearance.BorderSize = 0;
            this.btnPaises.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnPaises.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(212)))), ((int)(((byte)(195)))));
            this.btnPaises.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aquamarine;
            this.btnPaises.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaises.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPaises.Location = new System.Drawing.Point(502, 258);
            this.btnPaises.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.btnPaises.Name = "btnPaises";
            this.btnPaises.Size = new System.Drawing.Size(491, 182);
            this.btnPaises.TabIndex = 65;
            this.btnPaises.TabStop = false;
            this.btnPaises.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPaises.UseVisualStyleBackColor = false;
            this.btnPaises.Click += new System.EventHandler(this.handlePaises);
            // 
            // btnProfissoes
            // 
            this.btnProfissoes.BackColor = System.Drawing.Color.Silver;
            this.btnProfissoes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProfissoes.BackgroundImage")));
            this.btnProfissoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnProfissoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfissoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProfissoes.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnProfissoes.FlatAppearance.BorderSize = 0;
            this.btnProfissoes.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnProfissoes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.btnProfissoes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnProfissoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfissoes.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProfissoes.Location = new System.Drawing.Point(7, 258);
            this.btnProfissoes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.btnProfissoes.Name = "btnProfissoes";
            this.btnProfissoes.Size = new System.Drawing.Size(491, 182);
            this.btnProfissoes.TabIndex = 64;
            this.btnProfissoes.TabStop = false;
            this.btnProfissoes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProfissoes.UseVisualStyleBackColor = false;
            this.btnProfissoes.Click += new System.EventHandler(this.handleProfissoes);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Lime;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(502, 211);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(491, 43);
            this.label2.TabIndex = 63;
            this.label2.Text = "ANIMAIS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.handleAnimais);
            // 
            // btnAnimais
            // 
            this.btnAnimais.BackColor = System.Drawing.Color.Lime;
            this.btnAnimais.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAnimais.BackgroundImage")));
            this.btnAnimais.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAnimais.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnimais.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAnimais.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAnimais.FlatAppearance.BorderSize = 0;
            this.btnAnimais.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnAnimais.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(245)))), ((int)(((byte)(0)))));
            this.btnAnimais.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnAnimais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnimais.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAnimais.Location = new System.Drawing.Point(502, 7);
            this.btnAnimais.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.btnAnimais.Name = "btnAnimais";
            this.btnAnimais.Size = new System.Drawing.Size(491, 204);
            this.btnAnimais.TabIndex = 62;
            this.btnAnimais.TabStop = false;
            this.btnAnimais.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAnimais.UseVisualStyleBackColor = false;
            this.btnAnimais.Click += new System.EventHandler(this.handleAnimais);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Ink Free", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(7, 211);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(491, 43);
            this.label1.TabIndex = 61;
            this.label1.Text = "ALIMENTOS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.handleAlimentos);
            // 
            // btnAlimentos
            // 
            this.btnAlimentos.BackColor = System.Drawing.Color.Yellow;
            this.btnAlimentos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAlimentos.BackgroundImage")));
            this.btnAlimentos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAlimentos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlimentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAlimentos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAlimentos.FlatAppearance.BorderSize = 0;
            this.btnAlimentos.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnAlimentos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(0)))));
            this.btnAlimentos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnAlimentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlimentos.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAlimentos.Location = new System.Drawing.Point(7, 7);
            this.btnAlimentos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.btnAlimentos.Name = "btnAlimentos";
            this.btnAlimentos.Size = new System.Drawing.Size(491, 204);
            this.btnAlimentos.TabIndex = 53;
            this.btnAlimentos.TabStop = false;
            this.btnAlimentos.Tag = "alimentos";
            this.btnAlimentos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAlimentos.UseVisualStyleBackColor = false;
            this.btnAlimentos.Click += new System.EventHandler(this.handleAlimentos);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.button3, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(3, 23);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 74);
            this.button3.TabIndex = 55;
            this.button3.TabStop = false;
            this.button3.Text = "ALIMENTOS";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = global::JogoDaForca.Properties.Resources.alimentos;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button4.FlatAppearance.BorderSize = 2;
            this.button4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Ink Free", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(3, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 179);
            this.button4.TabIndex = 53;
            this.button4.TabStop = false;
            this.button4.Text = "ALIMENTOS";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // EscolherTema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 549);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EscolherTema";
            this.Text = "TelaInicial";
            this.Load += new System.EventHandler(this.EscolherTema_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnAlimentos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPaises;
        private System.Windows.Forms.Button btnProfissoes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAnimais;
    }
}