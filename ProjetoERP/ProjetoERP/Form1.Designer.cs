namespace ProjetoERP
{
    partial class Form_Principal
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
            this.panel_Botoes = new System.Windows.Forms.Panel();
            this.label_Usuario = new System.Windows.Forms.Label();
            this.btn_Agenda = new System.Windows.Forms.Button();
            this.Btn_Veiculo = new System.Windows.Forms.Button();
            this.btn_Cliente = new System.Windows.Forms.Button();
            this.btn_Inicial = new System.Windows.Forms.Button();
            this.label_Data = new System.Windows.Forms.Label();
            this.panel_Principal = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel_Botoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Botoes
            // 
            this.panel_Botoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel_Botoes.Controls.Add(this.button5);
            this.panel_Botoes.Controls.Add(this.button1);
            this.panel_Botoes.Controls.Add(this.button2);
            this.panel_Botoes.Controls.Add(this.button3);
            this.panel_Botoes.Controls.Add(this.button4);
            this.panel_Botoes.Controls.Add(this.label_Usuario);
            this.panel_Botoes.Controls.Add(this.btn_Agenda);
            this.panel_Botoes.Controls.Add(this.Btn_Veiculo);
            this.panel_Botoes.Controls.Add(this.btn_Cliente);
            this.panel_Botoes.Controls.Add(this.btn_Inicial);
            this.panel_Botoes.Location = new System.Drawing.Point(0, 0);
            this.panel_Botoes.Name = "panel_Botoes";
            this.panel_Botoes.Size = new System.Drawing.Size(122, 450);
            this.panel_Botoes.TabIndex = 0;
            // 
            // label_Usuario
            // 
            this.label_Usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Usuario.Location = new System.Drawing.Point(3, 4);
            this.label_Usuario.Name = "label_Usuario";
            this.label_Usuario.Size = new System.Drawing.Size(115, 67);
            this.label_Usuario.TabIndex = 0;
            this.label_Usuario.Text = "Usuário";
            this.label_Usuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Agenda
            // 
            this.btn_Agenda.Location = new System.Drawing.Point(3, 182);
            this.btn_Agenda.Name = "btn_Agenda";
            this.btn_Agenda.Size = new System.Drawing.Size(115, 30);
            this.btn_Agenda.TabIndex = 3;
            this.btn_Agenda.Text = "Agenda";
            this.btn_Agenda.UseVisualStyleBackColor = true;
            this.btn_Agenda.Click += new System.EventHandler(this.btn_Agenda_Click);
            // 
            // Btn_Veiculo
            // 
            this.Btn_Veiculo.Location = new System.Drawing.Point(3, 146);
            this.Btn_Veiculo.Name = "Btn_Veiculo";
            this.Btn_Veiculo.Size = new System.Drawing.Size(115, 30);
            this.Btn_Veiculo.TabIndex = 2;
            this.Btn_Veiculo.Text = "Veículo";
            this.Btn_Veiculo.UseVisualStyleBackColor = true;
            this.Btn_Veiculo.Click += new System.EventHandler(this.Btn_Veiculo_Click);
            // 
            // btn_Cliente
            // 
            this.btn_Cliente.Location = new System.Drawing.Point(3, 110);
            this.btn_Cliente.Name = "btn_Cliente";
            this.btn_Cliente.Size = new System.Drawing.Size(115, 30);
            this.btn_Cliente.TabIndex = 1;
            this.btn_Cliente.Text = "Cliente";
            this.btn_Cliente.UseVisualStyleBackColor = true;
            this.btn_Cliente.Click += new System.EventHandler(this.btn_Cliente_Click);
            // 
            // btn_Inicial
            // 
            this.btn_Inicial.Location = new System.Drawing.Point(3, 74);
            this.btn_Inicial.Name = "btn_Inicial";
            this.btn_Inicial.Size = new System.Drawing.Size(115, 30);
            this.btn_Inicial.TabIndex = 0;
            this.btn_Inicial.Text = "Início";
            this.btn_Inicial.UseVisualStyleBackColor = true;
            this.btn_Inicial.Click += new System.EventHandler(this.btn_Inicial_Click);
            // 
            // label_Data
            // 
            this.label_Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Data.Location = new System.Drawing.Point(124, 0);
            this.label_Data.Name = "label_Data";
            this.label_Data.Size = new System.Drawing.Size(550, 37);
            this.label_Data.TabIndex = 1;
            this.label_Data.Text = "Data";
            this.label_Data.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_Principal
            // 
            this.panel_Principal.Location = new System.Drawing.Point(124, 40);
            this.panel_Principal.Name = "panel_Principal";
            this.panel_Principal.Size = new System.Drawing.Size(538, 398);
            this.panel_Principal.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(3, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "Vazio";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(3, 290);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 30);
            this.button2.TabIndex = 6;
            this.button2.Text = "Vazio";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(3, 254);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 30);
            this.button3.TabIndex = 5;
            this.button3.Text = "Vazio";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(3, 218);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 30);
            this.button4.TabIndex = 4;
            this.button4.Text = "Vazio";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(3, 362);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(115, 30);
            this.button5.TabIndex = 8;
            this.button5.Text = "Vazio";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Form_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 450);
            this.Controls.Add(this.panel_Principal);
            this.Controls.Add(this.label_Data);
            this.Controls.Add(this.panel_Botoes);
            this.Name = "Form_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Manager";
            this.Load += new System.EventHandler(this.Form_Principal_Load);
            this.panel_Botoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Botoes;
        private System.Windows.Forms.Label label_Data;
        private System.Windows.Forms.Panel panel_Principal;
        private System.Windows.Forms.Button btn_Cliente;
        private System.Windows.Forms.Button btn_Inicial;
        private System.Windows.Forms.Button btn_Agenda;
        private System.Windows.Forms.Button Btn_Veiculo;
        private System.Windows.Forms.Label label_Usuario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

