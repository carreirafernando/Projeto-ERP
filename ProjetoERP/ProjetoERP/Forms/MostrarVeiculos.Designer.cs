namespace ProjetoERP
{
    partial class MostrarVeiculos
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
            this.Mostar_Veiculos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Mostar_Veiculos
            // 
            this.Mostar_Veiculos.FormattingEnabled = true;
            this.Mostar_Veiculos.Location = new System.Drawing.Point(12, 3);
            this.Mostar_Veiculos.Name = "Mostar_Veiculos";
            this.Mostar_Veiculos.Size = new System.Drawing.Size(764, 433);
            this.Mostar_Veiculos.TabIndex = 0;
            // 
            // MostrarVeiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Mostar_Veiculos);
            this.Name = "MostrarVeiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MostrarVeiculos";
            this.Load += new System.EventHandler(this.MostrarVeiculos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Mostar_Veiculos;
    }
}