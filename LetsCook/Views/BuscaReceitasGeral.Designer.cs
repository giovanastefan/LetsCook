namespace LetsCook
{
    partial class BuscaReceitasGeral
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscaReceitasGeral));
            this.btnAdicionarIngredientes = new System.Windows.Forms.Button();
            this.txtIngrediente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cardReceita1 = new LetsCook.CardReceita();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdicionarIngredientes
            // 
            this.btnAdicionarIngredientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(69)))));
            this.btnAdicionarIngredientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionarIngredientes.FlatAppearance.BorderSize = 0;
            this.btnAdicionarIngredientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarIngredientes.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarIngredientes.Location = new System.Drawing.Point(783, 117);
            this.btnAdicionarIngredientes.Name = "btnAdicionarIngredientes";
            this.btnAdicionarIngredientes.Size = new System.Drawing.Size(171, 28);
            this.btnAdicionarIngredientes.TabIndex = 16;
            this.btnAdicionarIngredientes.Text = "Buscar";
            this.btnAdicionarIngredientes.UseVisualStyleBackColor = false;
            this.btnAdicionarIngredientes.Click += new System.EventHandler(this.btnAdicionarIngredientes_Click);
            // 
            // txtIngrediente
            // 
            this.txtIngrediente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIngrediente.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngrediente.Location = new System.Drawing.Point(64, 117);
            this.txtIngrediente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIngrediente.Name = "txtIngrediente";
            this.txtIngrediente.Size = new System.Drawing.Size(714, 29);
            this.txtIngrediente.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(11, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(798, 42);
            this.label1.TabIndex = 17;
            this.label1.Text = "Não sabe o que fazer com um ingrediente que está estragando, está para vencer ou " +
    "não sabe o que fazer com ele?\nFaça sua busca com esse ingrediente!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 117);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ebrima", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(9, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 30);
            this.label3.TabIndex = 19;
            this.label3.Text = "Buscar receitas:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.cardReceita1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(14, 165);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(764, 394);
            this.flowLayoutPanel1.TabIndex = 20;
            // 
            // cardReceita1
            // 
            this.cardReceita1.AutoScrollMargin = new System.Drawing.Size(2, 2);
            this.cardReceita1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(234)))));
            this.cardReceita1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardReceita1.Descricao = null;
            this.cardReceita1.Ingredientes = null;
            this.cardReceita1.Location = new System.Drawing.Point(2, 2);
            this.cardReceita1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cardReceita1.Name = "cardReceita1";
            this.cardReceita1.Size = new System.Drawing.Size(730, 130);
            this.cardReceita1.TabIndex = 0;
            this.cardReceita1.Titulo = null;
            this.cardReceita1.Load += new System.EventHandler(this.cardReceita1_Load);
            // 
            // BuscaReceitasGeral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1040, 569);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdicionarIngredientes);
            this.Controls.Add(this.txtIngrediente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BuscaReceitasGeral";
            this.Text = "BuscaReceitasGeral";
            this.Load += new System.EventHandler(this.BuscaReceitasGeral_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionarIngredientes;
        private System.Windows.Forms.TextBox txtIngrediente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private CardReceita cardReceita1;
    }
}