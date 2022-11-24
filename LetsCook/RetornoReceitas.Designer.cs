namespace LetsCook
{
    partial class RetornoReceitas
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
            this.cardReceita1 = new LetsCook.CardReceita();
            this.SuspendLayout();
            // 
            // cardReceita1
            // 
            this.cardReceita1.BackColor = System.Drawing.Color.White;
            this.cardReceita1.Location = new System.Drawing.Point(12, 12);
            this.cardReceita1.Name = "cardReceita1";
            this.cardReceita1.Size = new System.Drawing.Size(760, 150);
            this.cardReceita1.TabIndex = 0;
            // 
            // RetornoReceitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1716, 701);
            this.Controls.Add(this.cardReceita1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RetornoReceitas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "-";
            this.Load += new System.EventHandler(this.RetornoReceitas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CardReceita cardReceita1;
    }
}