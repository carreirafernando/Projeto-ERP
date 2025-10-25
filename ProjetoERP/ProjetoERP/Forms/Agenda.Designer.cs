namespace ProjetoERP.Forms
{
    partial class Agenda
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
            this.informacao_data = new System.Windows.Forms.DataGridView();
            this.label_Agendamento = new System.Windows.Forms.Label();
            this.Data_saida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Veiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.informacao_data)).BeginInit();
            this.SuspendLayout();
            // 
            // informacao_data
            // 
            this.informacao_data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.informacao_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.informacao_data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Data_saida,
            this.Veiculo,
            this.Nome});
            this.informacao_data.Location = new System.Drawing.Point(2, 47);
            this.informacao_data.Name = "informacao_data";
            this.informacao_data.Size = new System.Drawing.Size(558, 385);
            this.informacao_data.TabIndex = 0;
            // 
            // label_Agendamento
            // 
            this.label_Agendamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Agendamento.Location = new System.Drawing.Point(-1, 9);
            this.label_Agendamento.Name = "label_Agendamento";
            this.label_Agendamento.Size = new System.Drawing.Size(561, 35);
            this.label_Agendamento.TabIndex = 1;
            this.label_Agendamento.Text = "Agendamentos do dia";
            this.label_Agendamento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Data_saida
            // 
            this.Data_saida.HeaderText = "Data de Saída";
            this.Data_saida.Name = "Data_saida";
            // 
            // Veiculo
            // 
            this.Veiculo.HeaderText = "Veículo";
            this.Veiculo.Name = "Veiculo";
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(577, 450);
            this.Controls.Add(this.label_Agendamento);
            this.Controls.Add(this.informacao_data);
            this.Name = "Agenda";
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.Agenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.informacao_data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView informacao_data;
        private System.Windows.Forms.Label label_Agendamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_saida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Veiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
    }
}