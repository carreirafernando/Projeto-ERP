namespace ProjetoERP.Forms
{
    partial class Veiculo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Marca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Modelo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Cor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.data_entrada = new System.Windows.Forms.DateTimePicker();
            this.data_saida = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.btn_Enviar = new System.Windows.Forms.Button();
            this.area_reclamacao = new System.Windows.Forms.TextBox();
            this.txt_Placa = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_anoModelo = new System.Windows.Forms.MaskedTextBox();
            this.check_Revisao = new System.Windows.Forms.CheckBox();
            this.check_Geometria = new System.Windows.Forms.CheckBox();
            this.check_Diagnostico = new System.Windows.Forms.CheckBox();
            this.check_Estetica = new System.Windows.Forms.CheckBox();
            this.txt_IdCliente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Placa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marca";
            // 
            // txt_Marca
            // 
            this.txt_Marca.Location = new System.Drawing.Point(26, 178);
            this.txt_Marca.Name = "txt_Marca";
            this.txt_Marca.Size = new System.Drawing.Size(151, 20);
            this.txt_Marca.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Modelo";
            // 
            // txt_Modelo
            // 
            this.txt_Modelo.Location = new System.Drawing.Point(26, 219);
            this.txt_Modelo.Name = "txt_Modelo";
            this.txt_Modelo.Size = new System.Drawing.Size(151, 20);
            this.txt_Modelo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cor";
            // 
            // txt_Cor
            // 
            this.txt_Cor.Location = new System.Drawing.Point(26, 262);
            this.txt_Cor.Name = "txt_Cor";
            this.txt_Cor.Size = new System.Drawing.Size(151, 20);
            this.txt_Cor.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Dia da Entrada";
            // 
            // data_entrada
            // 
            this.data_entrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_entrada.Location = new System.Drawing.Point(26, 43);
            this.data_entrada.Name = "data_entrada";
            this.data_entrada.Size = new System.Drawing.Size(151, 20);
            this.data_entrada.TabIndex = 11;
            this.data_entrada.Value = new System.DateTime(2025, 10, 19, 16, 59, 1, 0);
            // 
            // data_saida
            // 
            this.data_saida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_saida.Location = new System.Drawing.Point(26, 90);
            this.data_saida.Name = "data_saida";
            this.data_saida.Size = new System.Drawing.Size(151, 20);
            this.data_saida.TabIndex = 13;
            this.data_saida.Value = new System.DateTime(2025, 10, 19, 16, 59, 1, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Previsão de Entrega";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ano / Modelo";
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Location = new System.Drawing.Point(206, 332);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(104, 37);
            this.btn_Limpar.TabIndex = 20;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // btn_Enviar
            // 
            this.btn_Enviar.Location = new System.Drawing.Point(331, 332);
            this.btn_Enviar.Name = "btn_Enviar";
            this.btn_Enviar.Size = new System.Drawing.Size(104, 37);
            this.btn_Enviar.TabIndex = 21;
            this.btn_Enviar.Text = "Enviar";
            this.btn_Enviar.UseVisualStyleBackColor = true;
            this.btn_Enviar.Click += new System.EventHandler(this.btn_Enviar_Click);
            // 
            // area_reclamacao
            // 
            this.area_reclamacao.Location = new System.Drawing.Point(206, 43);
            this.area_reclamacao.Multiline = true;
            this.area_reclamacao.Name = "area_reclamacao";
            this.area_reclamacao.Size = new System.Drawing.Size(229, 279);
            this.area_reclamacao.TabIndex = 22;
            this.area_reclamacao.Tag = "ncnvcnc";
            // 
            // txt_Placa
            // 
            this.txt_Placa.Location = new System.Drawing.Point(26, 139);
            this.txt_Placa.Mask = "aaa-0000";
            this.txt_Placa.Name = "txt_Placa";
            this.txt_Placa.Size = new System.Drawing.Size(151, 20);
            this.txt_Placa.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(261, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Observações";
            // 
            // txt_anoModelo
            // 
            this.txt_anoModelo.Location = new System.Drawing.Point(26, 302);
            this.txt_anoModelo.Mask = "00/00";
            this.txt_anoModelo.Name = "txt_anoModelo";
            this.txt_anoModelo.Size = new System.Drawing.Size(100, 20);
            this.txt_anoModelo.TabIndex = 18;
            // 
            // check_Revisao
            // 
            this.check_Revisao.AutoSize = true;
            this.check_Revisao.Location = new System.Drawing.Point(26, 328);
            this.check_Revisao.Name = "check_Revisao";
            this.check_Revisao.Size = new System.Drawing.Size(65, 17);
            this.check_Revisao.TabIndex = 26;
            this.check_Revisao.Text = "Revisão";
            this.check_Revisao.UseVisualStyleBackColor = true;
            // 
            // check_Geometria
            // 
            this.check_Geometria.AutoSize = true;
            this.check_Geometria.Location = new System.Drawing.Point(26, 352);
            this.check_Geometria.Name = "check_Geometria";
            this.check_Geometria.Size = new System.Drawing.Size(74, 17);
            this.check_Geometria.TabIndex = 27;
            this.check_Geometria.Text = "Geometria";
            this.check_Geometria.UseVisualStyleBackColor = true;
            // 
            // check_Diagnostico
            // 
            this.check_Diagnostico.AutoSize = true;
            this.check_Diagnostico.Location = new System.Drawing.Point(112, 328);
            this.check_Diagnostico.Name = "check_Diagnostico";
            this.check_Diagnostico.Size = new System.Drawing.Size(82, 17);
            this.check_Diagnostico.TabIndex = 28;
            this.check_Diagnostico.Text = "Diagnóstico";
            this.check_Diagnostico.UseVisualStyleBackColor = true;
            // 
            // check_Estetica
            // 
            this.check_Estetica.AutoSize = true;
            this.check_Estetica.Location = new System.Drawing.Point(112, 351);
            this.check_Estetica.Name = "check_Estetica";
            this.check_Estetica.Size = new System.Drawing.Size(64, 17);
            this.check_Estetica.TabIndex = 29;
            this.check_Estetica.Text = "Estética";
            this.check_Estetica.UseVisualStyleBackColor = true;
            // 
            // txt_IdCliente
            // 
            this.txt_IdCliente.Location = new System.Drawing.Point(132, 302);
            this.txt_IdCliente.Name = "txt_IdCliente";
            this.txt_IdCliente.Size = new System.Drawing.Size(45, 20);
            this.txt_IdCliente.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(129, 285);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "ID Cliente";
            // 
            // Veiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(552, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_IdCliente);
            this.Controls.Add(this.check_Estetica);
            this.Controls.Add(this.check_Diagnostico);
            this.Controls.Add(this.check_Geometria);
            this.Controls.Add(this.check_Revisao);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_Placa);
            this.Controls.Add(this.area_reclamacao);
            this.Controls.Add(this.btn_Enviar);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.txt_anoModelo);
            this.Controls.Add(this.data_saida);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.data_entrada);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Cor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Modelo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Marca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Veiculo";
            this.Text = "Veiculo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Marca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Modelo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Cor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker data_entrada;
        private System.Windows.Forms.DateTimePicker data_saida;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.Button btn_Enviar;
        private System.Windows.Forms.TextBox area_reclamacao;
        private System.Windows.Forms.MaskedTextBox txt_Placa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txt_anoModelo;
        private System.Windows.Forms.CheckBox check_Revisao;
        private System.Windows.Forms.CheckBox check_Geometria;
        private System.Windows.Forms.CheckBox check_Diagnostico;
        private System.Windows.Forms.CheckBox check_Estetica;
        private System.Windows.Forms.TextBox txt_IdCliente;
        private System.Windows.Forms.Label label8;
    }
}