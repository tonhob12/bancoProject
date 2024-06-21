namespace Banco
{
    partial class banco
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TextoTitular = new TextBox();
            TextoSaldo = new TextBox();
            TextoNumero = new TextBox();
            TextoValor = new TextBox();
            DepositarB = new Button();
            Saque = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // TextoTitular
            // 
            TextoTitular.Location = new Point(126, 121);
            TextoTitular.Name = "TextoTitular";
            TextoTitular.ReadOnly = true;
            TextoTitular.Size = new Size(181, 31);
            TextoTitular.TabIndex = 0;
            // 
            // TextoSaldo
            // 
            TextoSaldo.Location = new Point(126, 191);
            TextoSaldo.Name = "TextoSaldo";
            TextoSaldo.ReadOnly = true;
            TextoSaldo.Size = new Size(181, 31);
            TextoSaldo.TabIndex = 1;
            // 
            // TextoNumero
            // 
            TextoNumero.Location = new Point(126, 265);
            TextoNumero.Name = "TextoNumero";
            TextoNumero.ReadOnly = true;
            TextoNumero.Size = new Size(181, 31);
            TextoNumero.TabIndex = 2;
            // 
            // TextoValor
            // 
            TextoValor.Location = new Point(471, 142);
            TextoValor.Name = "TextoValor";
            TextoValor.Size = new Size(174, 31);
            TextoValor.TabIndex = 3;
            // 
            // DepositarB
            // 
            DepositarB.BackColor = SystemColors.Control;
            DepositarB.Cursor = Cursors.Hand;
            DepositarB.Location = new Point(501, 193);
            DepositarB.Name = "DepositarB";
            DepositarB.Size = new Size(112, 34);
            DepositarB.TabIndex = 4;
            DepositarB.Text = "Depositar";
            DepositarB.UseVisualStyleBackColor = false;
            DepositarB.Click += button1_Click;
            // 
            // Saque
            // 
            Saque.BackColor = SystemColors.Control;
            Saque.Cursor = Cursors.Hand;
            Saque.Location = new Point(501, 243);
            Saque.Name = "Saque";
            Saque.Size = new Size(112, 34);
            Saque.TabIndex = 5;
            Saque.Text = "Sacar";
            Saque.UseVisualStyleBackColor = false;
            Saque.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(184, 83);
            label1.Name = "label1";
            label1.Size = new Size(64, 25);
            label1.TabIndex = 6;
            label1.Text = "Titular:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(184, 161);
            label2.Name = "label2";
            label2.Size = new Size(61, 25);
            label2.TabIndex = 7;
            label2.Text = "Saldo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(141, 237);
            label3.Name = "label3";
            label3.Size = new Size(155, 25);
            label3.TabIndex = 8;
            label3.Text = "Número da conta:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(471, 114);
            label4.Name = "label4";
            label4.Size = new Size(160, 25);
            label4.TabIndex = 9;
            label4.Text = "Valor da operação:";
            // 
            // banco
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Saque);
            Controls.Add(DepositarB);
            Controls.Add(TextoValor);
            Controls.Add(TextoNumero);
            Controls.Add(TextoSaldo);
            Controls.Add(TextoTitular);
            Name = "banco";
            Text = "Banco";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox TextoSaldo;
        private TextBox TextoNumero;
        private TextBox TextoValor;
        private Button DepositarB;
        private Button Saque;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        public TextBox TextoTitular;
    }
}
