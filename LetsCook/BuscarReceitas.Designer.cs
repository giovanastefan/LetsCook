namespace LetsCook
{
    partial class BuscarReceitas
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
            this.btnBuscarReceitas = new System.Windows.Forms.Button();
            this.btnAdicionarIngredientes = new System.Windows.Forms.Button();
            this.txtIngrediente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIngredientes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBuscarReceitas
            // 
            this.btnBuscarReceitas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(69)))));
            this.btnBuscarReceitas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarReceitas.FlatAppearance.BorderSize = 0;
            this.btnBuscarReceitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarReceitas.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarReceitas.Location = new System.Drawing.Point(1112, 500);
            this.btnBuscarReceitas.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarReceitas.Name = "btnBuscarReceitas";
            this.btnBuscarReceitas.Size = new System.Drawing.Size(400, 48);
            this.btnBuscarReceitas.TabIndex = 14;
            this.btnBuscarReceitas.Text = "Buscar receita";
            this.btnBuscarReceitas.UseVisualStyleBackColor = false;
            this.btnBuscarReceitas.Click += new System.EventHandler(this.btnBuscarReceitas_Click);
            // 
            // btnAdicionarIngredientes
            // 
            this.btnAdicionarIngredientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(69)))));
            this.btnAdicionarIngredientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionarIngredientes.FlatAppearance.BorderSize = 0;
            this.btnAdicionarIngredientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarIngredientes.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarIngredientes.Location = new System.Drawing.Point(1092, 32);
            this.btnAdicionarIngredientes.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdicionarIngredientes.Name = "btnAdicionarIngredientes";
            this.btnAdicionarIngredientes.Size = new System.Drawing.Size(228, 38);
            this.btnAdicionarIngredientes.TabIndex = 13;
            this.btnAdicionarIngredientes.Text = "Adicionar ingrediente";
            this.btnAdicionarIngredientes.UseVisualStyleBackColor = false;
            this.btnAdicionarIngredientes.Click += new System.EventHandler(this.btnAdicionarIngredientes_Click);
            // 
            // txtIngrediente
            // 
            this.txtIngrediente.Font = new System.Drawing.Font("Ebrima", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngrediente.Location = new System.Drawing.Point(389, 32);
            this.txtIngrediente.Name = "txtIngrediente";
            this.txtIngrediente.Size = new System.Drawing.Size(696, 37);
            this.txtIngrediente.TabIndex = 12;
            this.txtIngrediente.TextChanged += new System.EventHandler(this.txtIngrediente_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 19.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(338, 45);
            this.label2.TabIndex = 11;
            this.label2.Text = "Digite o ingrediente:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblIngredientes
            // 
            this.lblIngredientes.AutoSize = true;
            this.lblIngredientes.Font = new System.Drawing.Font("Ebrima", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredientes.Location = new System.Drawing.Point(13, 165);
            this.lblIngredientes.Name = "lblIngredientes";
            this.lblIngredientes.Size = new System.Drawing.Size(0, 38);
            this.lblIngredientes.TabIndex = 15;
            this.lblIngredientes.Click += new System.EventHandler(this.lblIngredientes_Click);
            // 
            // BuscarReceitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1525, 561);
            this.Controls.Add(this.lblIngredientes);
            this.Controls.Add(this.btnBuscarReceitas);
            this.Controls.Add(this.btnAdicionarIngredientes);
            this.Controls.Add(this.txtIngrediente);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BuscarReceitas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuscarReceitas";
            this.Load += new System.EventHandler(this.BuscarReceitas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarReceitas;
        private System.Windows.Forms.Button btnAdicionarIngredientes;
        private System.Windows.Forms.TextBox txtIngrediente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIngredientes;
    }
}