namespace ProjetoCrud
{
    partial class telaCadastro
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.autorTextBox = new System.Windows.Forms.TextBox();
            this.editoraTextBox = new System.Windows.Forms.TextBox();
            this.anoPublicacaodateTime = new System.Windows.Forms.DateTimePicker();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(32, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Autor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Editora:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ano da publicação:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(88, 96);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(425, 23);
            this.nomeTextBox.TabIndex = 5;
            // 
            // autorTextBox
            // 
            this.autorTextBox.Location = new System.Drawing.Point(84, 134);
            this.autorTextBox.Name = "autorTextBox";
            this.autorTextBox.Size = new System.Drawing.Size(429, 23);
            this.autorTextBox.TabIndex = 6;
            // 
            // editoraTextBox
            // 
            this.editoraTextBox.Location = new System.Drawing.Point(97, 176);
            this.editoraTextBox.Name = "editoraTextBox";
            this.editoraTextBox.Size = new System.Drawing.Size(416, 23);
            this.editoraTextBox.TabIndex = 7;
            // 
            // anoPublicacaodateTime
            // 
            this.anoPublicacaodateTime.Location = new System.Drawing.Point(197, 222);
            this.anoPublicacaodateTime.Name = "anoPublicacaodateTime";
            this.anoPublicacaodateTime.Size = new System.Drawing.Size(243, 23);
            this.anoPublicacaodateTime.TabIndex = 8;
            // 
            // btn_salvar
            // 
            this.btn_salvar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_salvar.Location = new System.Drawing.Point(307, 282);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(99, 34);
            this.btn_salvar.TabIndex = 9;
            this.btn_salvar.Text = "SALVAR";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.aoClicarEmSalvar);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(448, 282);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 34);
            this.button2.TabIndex = 10;
            this.button2.Text = "VOLTAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.aoClicarEmVoltar);
            // 
            // telaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 378);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.anoPublicacaodateTime);
            this.Controls.Add(this.editoraTextBox);
            this.Controls.Add(this.autorTextBox);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "telaCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "telaCadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox nomeTextBox;
        private TextBox autorTextBox;
        private TextBox editoraTextBox;
        private DateTimePicker anoPublicacaodateTime;
        private Button btn_salvar;
        private Button button2;
    }
}