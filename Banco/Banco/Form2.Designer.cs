namespace Banco
{
    partial class CriarConta
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
            criaConta = new Button();
            inputTitular = new TextBox();
            maior18 = new CheckBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // criaConta
            // 
            criaConta.Location = new Point(283, 263);
            criaConta.Name = "criaConta";
            criaConta.Size = new Size(189, 63);
            criaConta.TabIndex = 0;
            criaConta.Text = "Criar conta";
            criaConta.UseVisualStyleBackColor = true;
            criaConta.Click += criaConta_Click;
            // 
            // inputTitular
            // 
            inputTitular.Location = new Point(283, 132);
            inputTitular.Name = "inputTitular";
            inputTitular.Size = new Size(150, 31);
            inputTitular.TabIndex = 1;
            inputTitular.TextChanged += inputTitular_TextChanged;
            // 
            // maior18
            // 
            maior18.AutoSize = true;
            maior18.Location = new Point(283, 199);
            maior18.Name = "maior18";
            maior18.Size = new Size(330, 29);
            maior18.TabIndex = 2;
            maior18.Text = "Concordo que sou maior de 18 anos";
            maior18.UseVisualStyleBackColor = true;
            maior18.CheckedChanged += maior18_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(322, 104);
            label1.Name = "label1";
            label1.Size = new Size(65, 25);
            label1.TabIndex = 3;
            label1.Text = "Nome:";
            // 
            // CriarConta
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(maior18);
            Controls.Add(inputTitular);
            Controls.Add(criaConta);
            Cursor = Cursors.Default;
            Name = "CriarConta";
            Text = "Criar Conta";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button criaConta;
        private CheckBox maior18;
        private Label label1;
        public TextBox inputTitular;
    }
}